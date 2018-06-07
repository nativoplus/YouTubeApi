using System.Threading.Tasks;

namespace NativoPlusStudio.YouTubeApi.Contracts
{
    public interface IYouTubeChannelVideosService
    {
        Task<IYouTubeResponse> ChannelVideos(IYouTubeRequest youTubeRequest);
    }
}