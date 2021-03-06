﻿using System;
using InstaSharper.Classes.Models.User;

namespace InstaSharper.Classes
{
    [Serializable]
    public class UserSessionData
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public InstaUserShort LoggedInUser { get; internal set; }

        public string RankToken { get; set; }
        public string CsrfToken { get; set; }
        /// <summary>
        ///     Only for facebook login
        /// </summary>
        public string FacebookUserId { get; internal set; } = string.Empty;
        /// <summary>
        ///     Only for facebook login
        /// </summary>
        public string FacebookAccessToken { get; internal set; } = string.Empty;

        public static UserSessionData Empty => new UserSessionData();

        public static UserSessionData ForUsername(string username)
        {
            return new UserSessionData {UserName = username};
        }

        public UserSessionData WithPassword(string password)
        {
            Password = password;
            return this;
        }
    }
}