﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

namespace InstaSharper.Classes.Models.User
{
    public class InstaFriendshipFullStatus
    {
        public bool Following { get; set; }

        public bool FollowedBy { get; set; }

        public bool Blocking { get; set; }

        public bool Muting { get; set; }

        public bool IsPrivate { get; set; }

        public bool IncomingRequest { get; set; }

        public bool OutgoingRequest { get; set; }

        public bool IsBestie { get; set; }
    }
}
