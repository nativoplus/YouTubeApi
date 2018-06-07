namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public interface IId
    {
        string kind { get; set; }
        string playlistId { get; set; }
        string videoId { get; set; }
    }
}