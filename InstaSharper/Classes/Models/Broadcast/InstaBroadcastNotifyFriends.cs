﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

using System.Collections.Generic;
using InstaSharper.Classes.Models.User;

namespace InstaSharper.Classes.Models.Broadcast
{
    public class InstaBroadcastNotifyFriends
    {
        public string Text { get; set; }

        public List<InstaUserShortFriendshipFull> Friends { get; set; } = new List<InstaUserShortFriendshipFull>();

        public int OnlineFriendsCount { get; set; }
    }
}
