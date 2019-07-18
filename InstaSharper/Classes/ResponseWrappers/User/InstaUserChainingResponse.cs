﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

using System.Collections.Generic;
using InstaSharper.Classes.Models.Other;
using Newtonsoft.Json;

namespace InstaSharper.Classes.ResponseWrappers.User
{
    public class InstaUserChainingContainerResponse : InstaDefault
    {
        [JsonProperty("is_backup")] public bool IsBackup { get; set; }

        [JsonProperty("users")] public List<InstaUserChainingResponse> Users { get; set; }
    }
    public class InstaUserChainingResponse : InstaUserShortResponse
    {
        [JsonProperty("chaining_info")] public InstaUserChainingInfoResponse ChainingInfo { get; set; }

        [JsonProperty("profile_chaining_secondary_label")] public string ProfileChainingSecondaryLabel { get; set; }
    }
    public class InstaUserChainingInfoResponse
    {
        public string Sources { get; set; }
    }
}