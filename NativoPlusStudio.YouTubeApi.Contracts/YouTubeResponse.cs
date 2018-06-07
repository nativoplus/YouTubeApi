using System.Collections.Generic;

namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public class YouTubeResponse
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public string regionCode { get; set; }
        public IPageInfo pageInfo { get; set; }
        public List<IItem> items { get; set; }
    }
}
