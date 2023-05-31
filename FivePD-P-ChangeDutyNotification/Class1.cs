using FivePD.API;
using FivePD.API.Utils;
using System;
using System.Collections.Generic;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace FivePD_P_ChangeDutyNotification
{

    public class Class1 : Plugin
    {
        internal Class1()
        {
            Debug.WriteLine("[FivePD Custom Duty Notification] ^2Plugin loaded! ^6Made by GGGDunlix | ^5gggdunlix.github.io");
            Events.OnDutyStatusChange += OnDutyStatusChange;

        }
        private async Task OnDutyStatusChange(bool onDuty)
        {
            var config = API.LoadResourceFile(API.GetCurrentResourceName(), "/config/callouts.json");
            var json = JObject.Parse(config);
            if (json["DutyNotification"] == null)
            {
                Debug.WriteLine("[FivePD Custom Duty Notification] ^8Something is wrong with your callouts.json!");
                return;
            }
            JToken notifCfg = json["DutyNotification"];
            if (onDuty)
            {
                PlayerData plrData = Utilities.GetPlayerData();
                JToken cfgon = notifCfg["onDuty"];
                var title = ((string)cfgon["title"]);
                title = title.Replace("{name}", plrData.DisplayName).Replace("{callsign}", plrData.Callsign).Replace("{rank}", plrData.Rank).Replace("{department}", plrData.DepartmentShortName);
                string tooltip = cfgon["tooltip"].ToString();
                tooltip = tooltip.Replace("{name}", plrData.DisplayName).Replace("{callsign}", plrData.Callsign).Replace("{rank}", plrData.Rank).Replace("{department}", plrData.DepartmentShortName);
                string text = cfgon["text"].ToString();
                text = text.Replace("{name}", plrData.DisplayName).Replace("{callsign}", plrData.Callsign).Replace("{rank}", plrData.Rank).Replace("{department}", plrData.DepartmentShortName);
                // The Notification Code was written by Kilo! DevKilo#5880 https://devkilo.webflow.io/
                Function.Call(Hash.BEGIN_TEXT_COMMAND_THEFEED_POST, "STRING");
                Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, text);
                Function.Call(Hash.END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT, "CHAR_CALL911", "CHAR_CALL911", false, 0, title, tooltip);
                Function.Call(Hash.END_TEXT_COMMAND_THEFEED_POST_TICKER, false, true);
            }
            else
            {
                PlayerData plrData = Utilities.GetPlayerData();
                JToken cfg = notifCfg["offDuty"];
                String text = cfg["text"].ToString().Replace("{name}", plrData.DisplayName).Replace("{callsign}", plrData.Callsign).Replace("{rank}", plrData.Rank).Replace("{department}", plrData.DepartmentShortName);
                String tooltip = cfg["tooltip"].ToString().Replace("{name}", plrData.DisplayName).Replace("{callsign}", plrData.Callsign).Replace("{rank}", plrData.Rank).Replace("{department}", plrData.DepartmentShortName);
                String title = cfg["title"].ToString().Replace("{name}", plrData.DisplayName).Replace("{callsign}", plrData.Callsign).Replace("{rank}", plrData.Rank).Replace("{department}", plrData.DepartmentShortName);

                Function.Call(Hash.BEGIN_TEXT_COMMAND_THEFEED_POST, "STRING");
                Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, text);
                Function.Call(Hash.END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT, "CHAR_CALL911", "CHAR_CALL911", false, 0, title, tooltip);
                Function.Call(Hash.END_TEXT_COMMAND_THEFEED_POST_TICKER, false, true);
            }
        }
    }
}
