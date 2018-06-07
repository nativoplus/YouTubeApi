using Microsoft.Extensions.Options;
using NativoPlusStudio.YouTubeApi.ConfigurationModel.NativoPlusStudio.YouTubeApi.ConfigurationModel;
using NativoPlusStudio.YouTubeApi.Contracts;
using NativoPlusStudio.YouTubeApi.Responses;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace NativoPlusStudio.YouTubeApi.Services
{
    public class YouTubeChannelHttpService : IYouTubeChannelHttpService
    {
        public HttpClient _client { get; private set; }

        public YouTubeChannelHttpService(HttpClient client)
        {
            _client = client;
        }
        public async Task<IYouTubeDTO> YouTubeChannelSearch(string baseAddress, string key, string channelId, string part, string maxResults)
        {
            var youtubeDTO = new YouTubeDTO();

            var url = $"{baseAddress}key={key}&channelId={channelId}&part={part}&order=date&maxResults={maxResults}";
            var response = await _client.SendAsync(new HttpRequestMessage
            {
                RequestUri = new Uri(url)
            });
            string data = string.Empty;
            if (response.IsSuccessStatusCode)
            {

                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var myStream = new StreamReader(stream))
                {
                    data = await myStream.ReadToEndAsync();

                }

                youtubeDTO = JsonConvert.DeserializeObject<YouTubeDTO>(data);

            }

            return youtubeDTO;
        }

    }
}
