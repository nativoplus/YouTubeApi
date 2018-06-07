using NativoPlusStudio.YouTubeApi.Contracts;

namespace NativoPlusStudio.YouTubeApi.Responses
{
    public class VideoData : IVideoData
    {
        public string VideoUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Title { get; set; }
    }
}
