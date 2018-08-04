using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using static pmcenter.Methods;

namespace pmcenter {
    public class Conf {
        /*
         * CLASSES. DO NOT PUT ANY METHODS OR FUNCTIONS HERE.
         */
        public class ConfObj {
            public ConfObj() {
                APIKey = "";
                OwnerUID = -1;
                StartMessage = "📨 *Hi!* To send anything to my owner, just send it here." + Environment.NewLine + "⚠ To be informed: I'll *automatically* ban flooding users.";
                AutoBan = false;
                Banned = new List<BanObj>();
            }
            public string APIKey;
            public long OwnerUID;
            public string StartMessage;
            public bool AutoBan;
            public List<BanObj> Banned;
        }
        public class BanObj {
            public BanObj() {
                UID = -1;
                BanUntil = DateTime.Now + new TimeSpan(0, 30, 0);
            }
            public long UID;
            public DateTime BanUntil; // MUST BE UTC TIME.
        }
        /*
         * FUNCTIONS & METHODS. DO NOT PUT ANY CLASSES HERE.
         */
        public static string KillIllegalChars(string Input) {
            return Input.Replace("/", "-").Replace("<", "-").Replace(">", "-").Replace(":", "-").Replace("\"", "-").Replace("/", "-").Replace("\\", "-").Replace("|", "-").Replace("?", "-").Replace("*", "-");
        }
        public static async Task<bool> SaveConf(bool IsInvalid = false) { // DO NOT HANDLE ERRORS HERE.
            string Text = JsonConvert.SerializeObject(Vars.CurrentConf, Formatting.Indented);
            StreamWriter Writer = new StreamWriter(File.Create(Vars.ConfFile), System.Text.Encoding.UTF8);
            await Writer.WriteAsync(Text);
            await Writer.FlushAsync();
            Writer.Close();
            if (IsInvalid) {
                Log("We've detected an invalid configurations file and have reset it.", "CONF", LogLevel.WARN);
                Log("Please reconfigure it and try to start ohmyblog again.", "CONF", LogLevel.WARN);
                Environment.Exit(1);
            }
            return true;
        }
        public static async Task<bool> ReadConf(bool Apply = true) { // DO NOT HANDLE ERRORS HERE. THE CALLING METHOD WILL HANDLE THEM.
            string SettingsText = await File.ReadAllTextAsync(Vars.ConfFile);
            ConfObj Temp = JsonConvert.DeserializeObject<ConfObj>(SettingsText);
            if (Apply) { Vars.CurrentConf = Temp; }
            return true;
        }
        public static async void InitConf() {
            Log("Checking configurations file's integrity...", "CONF");
            if (File.Exists(Vars.ConfFile) != true) { // STEP 1, DETECT EXISTENCE.
                Vars.CurrentConf = new ConfObj();
			    await SaveConf(true); // Then the app will exit, do nothing.
            } else { // STEP 2, READ TEST.
                try {
                    await ReadConf(false); // Read but don't apply.
                } catch {
                    Log("Moving old configurations file to \"pmcenter.json.bak\"...", "CONF", LogLevel.WARN);
                    File.Move(Vars.ConfFile, Vars.ConfFile + ".bak");
                    Vars.CurrentConf = new ConfObj();
                    await SaveConf(true); // Then the app will exit, do nothing.
                }
            }
            Log("Integrity test PASSED!", "CONF");
        }
    }
}