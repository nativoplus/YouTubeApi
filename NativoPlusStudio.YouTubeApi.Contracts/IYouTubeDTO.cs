namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public interface IYouTubeDTO
    {
        string etag { get; set; }
        IItem[] items { get; set; }
        string kind { get; set; }
        string nextPageToken { get; set; }
        IPageInfo pageInfo { get; set; }
        string regionCode { get; set; }
    }
}