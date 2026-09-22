using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Api.Attributes;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public TwitterController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("tweets")]
        public IActionResult GetTweets()
        {
            var maxTweetLength = _configuration.GetValue<int>("TwitterSettings:MaxTweetLength");

            var response = new
            {
                maxLenth = maxTweetLength,
                tweets = new[]
                {
                    new { Id = 1, Text = "This is first tweet from TwitterClone" },
                    new { Id = 2, Text = "I am Learning Asp Dot Net" }
                }
            };

            return Ok(response);
        }

        [Tweet]
        [HttpGet("app-info")]
        public IActionResult GetAppInfo()
        {
            var appName = _configuration.GetValue<string>("AppName");
            return Ok(new {AppName = appName });
        }
    }
}
