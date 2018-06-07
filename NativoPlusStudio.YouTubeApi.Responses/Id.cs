using NativoPlusStudio.YouTubeApi.Contracts;

namespace NativoPlusStudio.YouTubeApi.Responses
{
    public class Id : IId
    {
        public string kind { get; set; }
        public string videoId { get; set; }
        public string playlistId { get; set; }
    }
}
