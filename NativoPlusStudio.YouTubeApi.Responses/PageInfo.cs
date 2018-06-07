using NativoPlusStudio.YouTubeApi.Contracts;

namespace NativoPlusStudio.YouTubeApi.Responses
{
    public class PageInfo : IPageInfo
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }
}
