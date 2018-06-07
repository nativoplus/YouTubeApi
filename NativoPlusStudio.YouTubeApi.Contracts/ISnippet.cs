using System;

namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public interface ISnippet
    {
        string channelId { get; set; }
        string channelTitle { get; set; }
        string description { get; set; }
        string liveBroadcastContent { get; set; }
        DateTime publishedAt { get; set; }
        IThumbnails thumbnails { get; set; }
        string title { get; set; }
    }
}