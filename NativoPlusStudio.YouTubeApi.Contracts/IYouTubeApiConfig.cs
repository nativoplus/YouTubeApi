namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public interface IYouTubeApiConfig
    {
        string ApiKey { get; set; }
        string BaseAddress { get; set; }
        string MaxResult { get; set; }
        string Part { get; set; }
        string UserAgent { get; set; }
    }
}