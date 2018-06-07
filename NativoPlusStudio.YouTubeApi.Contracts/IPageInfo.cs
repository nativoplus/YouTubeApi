namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public interface IPageInfo
    {
        int resultsPerPage { get; set; }
        int totalResults { get; set; }
    }
}