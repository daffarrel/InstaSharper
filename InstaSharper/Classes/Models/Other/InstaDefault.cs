﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

using Newtonsoft.Json;

namespace InstaSharper.Classes.Models.Other
{
    public class InstaDefault
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("status_code")] public string StatusCode { get; set; }
        [JsonProperty("message")] public string Message { get; set; }
        [JsonIgnore] public bool IsSucceed => Status.ToLower() == "ok";
    }
}
