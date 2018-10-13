/*
// Lang.cs / pmcenter project / https://github.com/Elepover/pmcenter
// Language system of pmcenter.
// Almost the same as Conf.cs.
// Copyright (C) 2018 Elepover. Licensed under the MIT License.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static pmcenter.Methods;

namespace pmcenter {
    public class Lang {
        public class Language {
            public Language() {
                LangCode = "en.default.integrated";
                Message_CommandNotReplying = "😶 Don't talk to me, spend time chatting with those who love you.";
                Message_CommandNotReplyingValidMessage = "😐 Speaking to me makes no sense.";
                Message_Help = "❓ `pmcenter` *Bot Help*\n/start - Display welcome message.\n/info - Display the message's info.\n/ban - Restrict the user from contacting you.\n/pardon - Pardon the user.\n/ping - Test if the bot is working.\n/switchfw - Pause/Resume message forwarding.\n/switchbw - Enable/Disable keyword banning.\n/switchnf - Enable/Disable notifications.\n/saveconf - Manually save all settings and translations. Especially useful after upgrades.\n/readconf - Reload configurations without restarting bot.\n/uptime - Check system uptime information.\n/update - Check for updates and update bot.\n/chkupdate - Only check for updates.\n/catconf - Get your current configurations.\n/restart - Restart bot.\n/status - Get host device's status information.\n/help - Display this message.\n\nThank you for using `pmcenter`!";
                Message_OwnerStart = "😊 *Hi!* I'm your `pmcenter` bot, and I work just for you.\nThis message means that you've set up the bot successfully.\nTo reply to any forwarded messages, just directly reply to them here.\n\nThank you for using the `pmcenter` bot!";
                Message_ReplySuccessful = "✅ Successfully replied to user $1!";
                Message_ForwardedToOwner = "✅ Your message has been forwarded to my owner!";
                Message_UserBanned = "🚫 The user has been banned permanently.";
                Message_UserPardoned = "✅ You've pardoned the user.";
                Message_UserStartDefault = "📨 *Hi!* To send anything to my owner, just send it here.\n⚠ To be informed: I'll *automatically* ban flooding users.";
                Message_PingReply = "📶 Pong!";
                Message_ServicePaused = "📴 Message forwarding has been *paused*.";
                Message_ServiceResumed = "📲 Messsage forwarding has been *resumed*.";
                Message_UserServicePaused = "🚧 *Sorry...*\nYour messages won't be forwarded to my lord, currently.";
                Message_BotStarted = "🚀 Bot has started successfully in `$1`!";
                Message_MessageBlockEnabled = "📴 Keyword blocking is now *enabled*.";
                Message_MessageBlockDisabled = "📲 Keyword blocking is now *disabled*.";
                Message_ConfigUpdated = "🔄 Settings have been updated.";
                Message_ConfigReloaded = "🔄 Settings reloaded!";
                Message_UptimeInfo = "🚀 *Uptime Information*:\nSystem uptime: `$1`\nBot uptime: `$2`";
                Message_UpdateAvailable = "🔃 *Update available!*\nNew version: `$1`\nWhat's new:\n`$2`";
                Message_UpdateProcessing = "💠 Preparing to update...";
                Message_UpdateCheckFailed = "⚠ Update failed: `$1`";
                Message_AlreadyUpToDate = "✅ *Already up to date*!\nLatest version: `$1`\nCurrently installed: `$2`\nUpdate details:\n`$3`";
                Message_UpdateExtracting = "📤 Extracting update files...";
                Message_UpdateFinalizing = "✅ Files patching complete! Trying to restart...";
                Message_CurrentConf = "💾 *Your current configurations*: \n`$1`";
                Message_SysStatus_Header = "💻 *System Status*";
                Message_SysStatus_NoOperationRequired = "🚀 *Good job, No action needed!*";
                Message_SysStatus_PendingUpdate = "🔃 *Update available to*: `$1`";
                Message_SysStatus_UpdateLevel_Template = "🚨 *Update level*: `$1`";
                Message_SysStatus_UpdateLevel_Optional = "💡 Optional";
                Message_SysStatus_UpdateLevel_Recommended = "💠 Recommended";
                Message_SysStatus_UpdateLevel_Important = "❗ Important";
                Message_SysStatus_UpdateLevel_Urgent = "⚠ Urgent";
                Message_SysStatus_UpdateLevel_Unknown = "❓ Unknown";
                Message_SysStatus_RestartRequired = "🔃 *Bot restart required to apply changes.*";
                Message_SysStatus_Summary = "📝 *Device name*: `$1`\n💿 *Operating System*: `$2`\nℹ *OS description*: `$3`\n⌛ *Server uptime*: `$4`\n🕓 *Bot uptime*: `$5`\n📅 *Server time (UTC)*: `$6`\n📐 *Runtime version*: `$7`\nℹ *Runtime description*: `$8`\n📏 *Application version*: `$9`\n💠 *Processor count*: `$a`\n📖 *Language code*: `$b`";
                Message_Restarting = "🔄 Restarting...";
                Message_NotificationsOff = "📳 Notifications are *OFF*.";
                Message_NotificationsOn = "📲 Notifications are *ON*.";
                Message_SupportTextMessagesOnly = "📋 Sorry... Only text messages can be forwarded in Anonymous Forward mode.";
            }
            public string LangCode {get; set;}
            public string Message_OwnerStart {get; set;}
            public string Message_UserStartDefault {get; set;}
            public string Message_ReplySuccessful {get; set;}
            public string Message_ForwardedToOwner {get; set;}
            public string Message_Help {get; set;}
            public string Message_UserBanned {get; set;}
            public string Message_UserPardoned {get; set;}
            public string Message_CommandNotReplying {get; set;}
            public string Message_CommandNotReplyingValidMessage {get; set;}
            public string Message_PingReply {get; set;}
            public string Message_ServicePaused {get; set;}
            public string Message_ServiceResumed {get; set;}
            public string Message_UserServicePaused {get; set;}
            public string Message_BotStarted {get; set;}
            public string Message_MessageBlockEnabled {get; set;}
            public string Message_MessageBlockDisabled {get; set;}
            public string Message_ConfigUpdated {get; set;}
            public string Message_ConfigReloaded {get; set;}
            public string Message_UptimeInfo {get; set;}
            public string Message_UpdateAvailable {get; set;}
            public string Message_UpdateProcessing {get; set;}
            public string Message_UpdateCheckFailed {get; set;}
            public string Message_AlreadyUpToDate {get; set;}
            public string Message_UpdateExtracting {get; set;}
            public string Message_UpdateFinalizing {get; set;}
            public string Message_CurrentConf {get; set;}
            public string Message_SysStatus_Header {get; set;}
            public string Message_SysStatus_RestartRequired {get; set;}
            public string Message_SysStatus_PendingUpdate {get; set;}
            public string Message_SysStatus_UpdateLevel_Template {get; set;}
            public string Message_SysStatus_UpdateLevel_Optional {get; set;}
            public string Message_SysStatus_UpdateLevel_Recommended {get; set;}
            public string Message_SysStatus_UpdateLevel_Important {get; set;}
            public string Message_SysStatus_UpdateLevel_Urgent {get; set;}
            public string Message_SysStatus_UpdateLevel_Unknown {get; set;}
            public string Message_SysStatus_NoOperationRequired {get; set;}
            public string Message_SysStatus_Summary {get; set;}
            public string Message_Restarting {get; set;}
            public string Message_NotificationsOff {get; set;}
            public string Message_NotificationsOn {get; set;}
            public string Message_SupportTextMessagesOnly {get; set;}
        }
        public static string KillIllegalChars(string Input) {
            return Input.Replace("/", "-").Replace("<", "-").Replace(">", "-").Replace(":", "-").Replace("\"", "-").Replace("/", "-").Replace("\\", "-").Replace("|", "-").Replace("?", "-").Replace("*", "-");
        }
        public static async Task<bool> SaveLang(bool IsInvalid = false) { // DO NOT HANDLE ERRORS HERE.
            string Text = JsonConvert.SerializeObject(Vars.CurrentLang, Formatting.Indented);
            StreamWriter Writer = new StreamWriter(File.Create(Vars.LangFile), System.Text.Encoding.UTF8);
            await Writer.WriteAsync(Text);
            await Writer.FlushAsync();
            Writer.Close();
            if (IsInvalid) {
                Log("We've detected an invalid language file and have reset it.", "LANG", LogLevel.WARN);
                Log("Please reconfigure it and try to start pmcenter again.", "LANG", LogLevel.WARN);
                Vars.RestartRequired = true;
            }
            return true;
        }
        public static async Task<bool> ReadLang(bool Apply = true) { // DO NOT HANDLE ERRORS HERE. THE CALLING METHOD WILL HANDLE THEM.
            string SettingsText = await File.ReadAllTextAsync(Vars.LangFile);
            Language Temp = JsonConvert.DeserializeObject<Language>(SettingsText);
            if (Apply) { Vars.CurrentLang = Temp; }
            return true;
        }
        public static async void InitLang() {
            Log("Checking language file's integrity...", "LANG");
            if (File.Exists(Vars.LangFile) != true) { // STEP 1, DETECT EXISTENCE.
                Log("Language file not found. Creating...", "LANG", LogLevel.WARN);
                Vars.CurrentLang = new Language();
			    await SaveLang(true); // Then the app will exit, do nothing.
            } else { // STEP 2, READ TEST.
                try {
                    await ReadLang(false); // Read but don't apply.
                } catch (Exception ex) {
                    Log("Error! " + ex.ToString(), "LANG", LogLevel.ERROR);
                    Log("Moving old language file to \"pmcenter_locale.json.bak\"...", "LANG", LogLevel.WARN);
                    File.Move(Vars.LangFile, Vars.LangFile + ".bak");
                    Vars.CurrentLang = new Language();
                    await SaveLang(true); // Then the app will exit, do nothing.
                }
            }
            Log("Integrity test finished!", "LANG");
        }
    }
}