using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NativoPlusStudio.YouTubeApi.Services;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using NativoPlusStudio.YouTubeApi.Contracts;

namespace NativoPlusStudio.YoutubeApiTest
{
    [TestClass]
    public class UnitTestYouTubeList
    {
        readonly IConfiguration Configuration;
        readonly IServiceProvider _serviceProvider;

        public UnitTestYouTubeList()
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
            IYouTubeChannelHttpService service = _serviceProvider.GetService<IYouTubeChannelHttpService>();
            var result = await service.YouTubeChannelSearch("UCIzSrkEk2QHHoyWIH1B1Tnw");

            Assert.IsNotNull(result);
        }
    }
}
