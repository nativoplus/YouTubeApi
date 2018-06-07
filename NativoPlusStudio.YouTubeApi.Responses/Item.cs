using NativoPlusStudio.YouTubeApi.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NativoPlusStudio.YouTubeApi.Responses
{
    public class Item : IItem
    {
        public Item()
        {
            id = new Id();
            snippet = new Snippet();
        }
        public string kind { get; set; }
        public string etag { get; set; }
        public IId id { get; set; }
        public ISnippet snippet { get; set; }
    }
}
