﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

using System;
using InstaSharper.Classes.Models.User;

namespace InstaSharper.Classes.Models.Discover
{
    public class InstaDiscoverSearches
    {
        public int Position { get; set; }

        public InstaUser User { get; set; }

        public DateTime ClientTime { get; set; }
    }
}
