﻿using System.Collections.Generic;
using InstaSharper.Classes.Models.Broadcast;
using InstaSharper.Classes.Models.Hashtags;

namespace InstaSharper.Classes.Models.Story
{
    public class InstaStoryFeed
    {
        public int FaceFilterNuxVersion { get; set; }

        public bool HasNewNuxStory { get; set; }

        public string StoryRankingToken { get; set; }

        public int StickerVersion { get; set; }

        public List<InstaReelFeed> Items { get; set; } = new List<InstaReelFeed>();

        public List<InstaBroadcast> Broadcasts { get; set; } = new List<InstaBroadcast>();

        public List<InstaBroadcastAddToPostLive> PostLives { get; set; } = new List<InstaBroadcastAddToPostLive>();

        public List<InstaHashtagStory> HashtagStories { get; set; } = new List<InstaHashtagStory>();
    }
}