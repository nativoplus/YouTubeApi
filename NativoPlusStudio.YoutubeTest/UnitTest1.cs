using Microsoft.VisualStudio.TestTools.UnitTesting;
using NativoPlusStudio.YouTubeApi.Services;
using System.Net.Http;
using System.Threading.Tasks;

namespace NativoPlusStudio.YoutubeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var result = await new YouTubeChannelHttpService(new HttpClient()).YouTubeChannelSearch("UCIzSrkEk2QHHoyWIH1B1Tnw");

            Assert.IsNotNull(result);
        }
    }
}
