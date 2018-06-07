using NativoPlusStudio.YouTubeApi.Contracts;


namespace NativoPlusStudio.YouTubeApi.Responses
{
    public class Thumbnails : IThumbnails
    {
        public Thumbnails()
        {
            @default = new Default();
            medium = new Medium();
            high = new High();
        }
        public IDefault @default { get; set; }
        public IMedium medium { get; set; }
        public IHigh high { get; set; }
    }
}
