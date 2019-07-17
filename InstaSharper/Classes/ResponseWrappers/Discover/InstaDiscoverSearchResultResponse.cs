﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

using System.Collections.Generic;
using InstaSharper.Classes.ResponseWrappers.User;
using Newtonsoft.Json;

namespace InstaSharper.Classes.ResponseWrappers.Discover
{
    public class InstaDiscoverSearchResultResponse
    {
        [JsonProperty("num_results")]
        public int? NumResults { get; set; }
        [JsonProperty("users")]
        public List<InstaUserResponse> Users { get; set; }
        [JsonProperty("has_more")]
        public bool? HasMore { get; set; }
        [JsonProperty("rank_token")]
        public string RankToken { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
