using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NativoPlusStudio.YouTubeApi.Services;
using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using NativoPlusStudio.YouTubeApi.Contracts;
using Microsoft.Extensions.Configuration;
using NativoPlusStudio.YouTubeApi.Requests;

namespace NativoPlusStudio.YouTubeApi.Test
{
    [TestClass]
    public class YouTubeUniTest
    {
        readonly IConfiguration Configuration;
        readonly IServiceProvider _serviceProvider;

        public YouTubeUniTest()
        {
            var path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).FullName;
            var builder = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            Configuration = builder;

            var serviceCollection = new ServiceCollection();

            serviceCollection
                .ServicesConfigurationForYouTubeApi(Configuration);

            _serviceProvider = serviceCollection
                .BuildServiceProvider();
        }

        [TestMethod]
        public async Task TestMethod1()
        {
            YouTubeRequest request = new YouTubeRequest();
            request.channelId = "UCIzSrkEk2QHHoyWIH1B1Tnw";
            IYouTubeChannelVideosService service = _serviceProvider.GetService<IYouTubeChannelVideosService>();
            var result = await service.ChannelVideos(request);

            Assert.IsNotNull(result);
        }
    }
}
