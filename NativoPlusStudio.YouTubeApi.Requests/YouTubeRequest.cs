using NativoPlusStudio.YouTubeApi.Contracts;

namespace NativoPlusStudio.YouTubeApi.Requests
{
    public class YouTubeRequest : IYouTubeRequest
    {
        public string channelId { get; set; }
        public bool IsValid { get; set; }
    }
}
