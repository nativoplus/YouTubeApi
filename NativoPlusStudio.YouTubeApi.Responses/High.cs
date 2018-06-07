using NativoPlusStudio.YouTubeApi.Contracts;

namespace NativoPlusStudio.YouTubeApi.Responses
{
    public class High : IHigh
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
