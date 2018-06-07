using Microsoft.Extensions.Options;
using NativoPlusStudio.YouTubeApi.ConfigurationModel.NativoPlusStudio.YouTubeApi.ConfigurationModel;
using NativoPlusStudio.YouTubeApi.Contracts;

using System.Threading.Tasks;

namespace NativoPlusStudio.YouTubeApi.Services
{
    public class YouTubeChannelVideosService : IYouTubeChannelVideosService
    {
        private readonly IYouTubeApiConfig _youTubeApiConfig;
        private readonly YouTubeChannelHttpService _youTubeChannelHttpService;

        public YouTubeChannelVideosService(YouTubeChannelHttpService youTubeChannelHttpService,
            IOptions<YouTubeApiConfig> youTubeApiConfig)
        {
            _youTubeChannelHttpService = youTubeChannelHttpService;
            _youTubeApiConfig = youTubeApiConfig.Value;
        }

        public async Task<IYouTubeResponse> ChannelVideos(IYouTubeRequest youTubeRequest)
        {

            var getResponse = await _youTubeChannelHttpService.YouTubeChannelSearch(
            _youTubeApiConfig.BaseAddress,
            _youTubeApiConfig.ApiKey,
            youTubeRequest.channelId,
            _youTubeApiConfig.Part,
            _youTubeApiConfig.MaxResult
          );

            var response = SingletonAutoMapperConfiguration
             .Instance
             .GetMapper
             .Map<IYouTubeDTO, IYouTubeResponse>(getResponse);

            return response;
        }
    }
}
