using NativoPlusStudio.YouTubeApi.Contracts;

namespace NativoPlusStudio.YouTubeApi.Responses
{
    public class YouTubeResponse : IYouTubeResponse
    {
        public IVideoData[] VideoData { get; set; }
    }
}
