using NativoPlusStudio.YouTubeApi.Contracts;
using System;

namespace NativoPlusStudio.YouTubeApi.Responses
{
    public class Snippet : ISnippet
    {
        public Snippet()
        {
            thumbnails = new Thumbnails();
        }
        public DateTime publishedAt { get; set; }
        public string channelId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public IThumbnails thumbnails { get; set; }
        public string channelTitle { get; set; }
        public string liveBroadcastContent { get; set; }
    }
}
