using NativoPlusStudio.YouTubeApi.Requests;
using NativoPlusStudio.YouTubeApi.Contracts;
using NativoPlusStudio.YouTubeApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace NativoPlusStudio.YouTubeApi.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    public class YouTubeChannelController : ApiController
    {

    
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

  
    }

   
}
