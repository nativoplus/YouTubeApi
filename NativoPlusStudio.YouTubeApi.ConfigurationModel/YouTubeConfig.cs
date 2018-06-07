using System;
using NativoPlusStudio.YouTubeApi.Contracts;
namespace NativoPlusStudio.YouTubeApi.ConfigurationModel
{

    namespace NativoPlusStudio.YouTubeApi.ConfigurationModel
    {
        public class YouTubeApiConfig: IYouTubeApiConfig
        {
            public string UserAgent { get; set; }
            public string BaseAddress { get; set; }
            public string ApiKey { get; set; }
            public string Part { get; set; }
            public string MaxResult { get; set; }
        }
    }
}
