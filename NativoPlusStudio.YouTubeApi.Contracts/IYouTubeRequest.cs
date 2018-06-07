namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public interface IYouTubeRequest
    {
        string channelId { get; set; }
        bool IsValid { get; set; }
    }
}