using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NativoPlusStudio.YouTubeApi.Contracts;
using NativoPlusStudio.YouTubeApi.Requests;

namespace NativoPlusStudio.YouTubeApi.Controllers
{
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class YouTubeController : Controller
    {
        private readonly IYouTubeChannelVideosService _youTubeChannelVideos;

        public YouTubeController(IYouTubeChannelVideosService youTubeChannelVideos)
        {
            _youTubeChannelVideos = youTubeChannelVideos;
        }
        /// <summary>
        /// Get Weather Data From Goverment API
        /// </summary>
        /// <param name="request"></param>
        /// <example>api/weather</example>
        /// <returns></returns>
        [HttpPost("youtube")]
        public async Task<IActionResult> GetYouTubeVideos([FromBody] YouTubeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _youTubeChannelVideos.ChannelVideos(request);
            return Ok(result);
        }
    }

}
