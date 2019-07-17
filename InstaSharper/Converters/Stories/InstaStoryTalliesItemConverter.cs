﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

using System;
using InstaSharper.Classes.Models.Story;
using InstaSharper.Classes.ResponseWrappers.Story;

namespace InstaSharper.Converters.Stories
{
    internal class InstaStoryTalliesItemConverter : IObjectConverter<InstaStoryTalliesItem, InstaStoryTalliesItemResponse>
    {
        public InstaStoryTalliesItemResponse SourceObject { get; set; }

        public InstaStoryTalliesItem Convert()
        {
            if (SourceObject == null) throw new ArgumentNullException($"Source object");

            var tallies = new InstaStoryTalliesItem
            {
                Count = SourceObject.Count,
                FontSize = SourceObject.FontSize,
                Text = SourceObject.Text
            };
            return tallies;
        }
    }
}
