using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Application.Dtos;
using TwitterClone.Domain.Entities;
using TwitterClone.Application.Interfaces;
using System.Runtime;
using TwitterClone.Utilities.Extensions;
using TwitterClone.Application.Generics;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
       // private readonly TweetRepository _tweetRepository;
       private readonly ITweetService _tweetService;
        private readonly IUserRepository _userRepository;

        public TweetsController(ITweetService tweetService, IUserRepository userRepository)
        {
            _tweetService = tweetService;
            _userRepository = userRepository;
        }


        // GET/api/tweets?userId = {userId}
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetTweets([FromQuery] Guid? userId)
        {
           return Ok(_tweetService.GetTweets());
        }



        [HttpGet("extension-test")]
        [AllowAnonymous]
        public IActionResult ExtensionTest()
        {
            
            string tag = "dotnet".ToHashtag();

           
            string alreadyTag = "#csharp".ToHashtag();

           
            bool isLong = "Learning ASP.NET Core".IsLong();

            
            var normalTweet = new Tweet("Hello world");
            normalTweet.Likes = 50;

           
            var hotTweet = new Tweet("Learning ASP.NET Core");
            hotTweet.Likes = 150;



            var tweets = new List<Tweet>
            {
                new Tweet("First tweet"),
                new Tweet("Second tweet")
            };

            var lastTweet = tweets.LastOrNull();


            var names = new List<string> { "Saiful", "Rahim", "Karim" };
            var lastName = names.LastOrNull();


            var emptyNames = new List<string>();
            var lastOfEmpty = emptyNames.LastOrNull();


            return Ok(new
            {
                tag,                                          
                alreadyTag,                                  
                isLong,                                       
                normalIsPopular = normalTweet.IsPopular(),    
                hotIsPopular = hotTweet.IsPopular(),
                
                lastTweetContent = lastTweet?.Content,
                lastName = lastName,
                lastOfEmpty = lastOfEmpty
            });
        }






        // GET/api/tweets/{id}
        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetTweetById([FromRoute] Guid id)
        {
            var tweet = _tweetService.GetTweetById(id);

            if (tweet == null)
            {
                return NotFound(new ApiResponse<TweetDto>
                {
                    Success = false,
                    Data = null,
                    Message = "Tweet not found."
                });
            }

            return Ok(new ApiResponse<TweetDto>
            {
                Success = true,
                Data = tweet,
                Message = "Tweet retrieved successfully."
            });
        }



        // POST /api/tweets
        [HttpPost]
        public IActionResult CreateTweet([FromBody] CreateTweetDto createTweetDto)
        {
            
            var createdTweet = _tweetService.CreateTweet(createTweetDto);

            if(createdTweet is null)
            {
                return BadRequest("A error occurred while creating the tweet.");
            }


          return Ok(createdTweet);

        }


        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute] Guid id, [FromBody] UpdateTweetDto updateTweetDto)
        {
            var tweet = _tweetService.UpdateTweet(id, updateTweetDto);

            if (tweet == null)
            {
                return NotFound();
            }

            return Ok(tweet);
        }
        

        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute] Guid id)
        {
            var isDeleted = _tweetService.DeleteTweet(id);

            if (isDeleted == false)
            {
                return NotFound();
            }

            return Ok(isDeleted);
        }

    }

}
