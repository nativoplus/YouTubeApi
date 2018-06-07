using NativoPlusStudio.YouTubeApi.Contracts;
using System.Collections.Generic;

namespace NativoPlusStudio.YouTubeApi.Responses
{
    public class YouTubeDTO : IYouTubeDTO
    {
        public YouTubeDTO()
        {
            pageInfo = new PageInfo();
            items = new Item[0];
        }

        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public string regionCode { get; set; }
        public IPageInfo pageInfo { get; set; }
        public IItem[] items { get; set; }
    }
}
