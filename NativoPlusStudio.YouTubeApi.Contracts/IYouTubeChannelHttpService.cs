using System.Net.Http;
using System.Threading.Tasks;


namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public interface IYouTubeChannelHttpService
    {
        HttpClient _client { get; }

        Task<IYouTubeDTO> YouTubeChannelSearch(string baseAddress, string key, string channelId, string part, string maxResults);
    }
}