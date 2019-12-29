﻿/*
 * Developer: Ramtin Jokar [ Ramtinak@live.com ] [ My Telegram Account: https://t.me/ramtinak ]
 * 
 * Github source: https://github.com/ramtinak/InstagramApiSharp
 * Nuget package: https://www.nuget.org/packages/InstagramApiSharp
 * 
 * IRANIAN DEVELOPERS
 */

using InstaSharper.Classes.Models.Highlight;
using InstaSharper.Classes.Models.Media;
using InstaSharper.Classes.ResponseWrappers.Highlight;

namespace InstaSharper.Converters.Highlights
{
    internal class InstaHighlightConverter : IObjectConverter<InstaHighlightFeeds, InstaHighlightFeedsResponse>
    {
        public InstaHighlightFeedsResponse SourceObject { get; set; }

        public InstaHighlightFeeds Convert()
        {
            var highlight = new InstaHighlightFeeds
            {
                ShowEmptyState = SourceObject.ShowEmptyState ?? false,
                Status = SourceObject.Status
            };
            if(SourceObject.Items?.Count > 0)
            foreach (var item in SourceObject.Items)
            {
                var hLight = new InstaHighlightFeed
                {
                    CanReply = item.CanReply,
                    CanReshare = item.CanReshare,
                    HighlightId = item.Id,
                    LatestReelMedia = item.LatestReelMedia,
                    MediaCount = item.MediaCount,
                    PrefetchCount = item.PrefetchCount,
                    RankedPosition = item.RankedPosition,
                    ReelType = item.ReelType,
                    Seen = item.Seen,
                    SeenRankedPosition = item.SeenRankedPosition,
                    Title = item.Title
                };
                
                hLight.CoverMedia = new InstaHighlightCoverMedia
                {
                     CropRect = item.CoverMedia.CropRect,
                     MediaId = item.CoverMedia.MediaId
                };
                if(item.CoverMedia.CroppedImageVersion!= null)
                    hLight.CoverMedia.CroppedImage = new InstaImage(item.CoverMedia.CroppedImageVersion.Url, item.CoverMedia.CroppedImageVersion.Width,item.CoverMedia.CroppedImageVersion.Height);
                if (item.CoverMedia.FullImageVersion != null)
                    hLight.CoverMedia.Image = new InstaImage(item.CoverMedia.FullImageVersion.Url, item.CoverMedia.FullImageVersion.Width, item.CoverMedia.FullImageVersion.Height);
                var userConverter = ConvertersFabric.Instance.GetUserShortConverter(item.User);
                hLight.User = userConverter.Convert();

                highlight.Items.Add(hLight);
            }
            return highlight;
        }
    }
}
