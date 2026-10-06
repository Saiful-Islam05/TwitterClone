using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Api.Data;
using TwitterClone.Api.Dtos;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly TweetRepository _tweetRepository;
        private readonly UserRepository _userRepository;

        public TweetsController(TweetRepository tweetRepository, UserRepository userRepository)
        {
            _tweetRepository = tweetRepository;
            _userRepository = userRepository;
        }


        // GET/api/tweets?userId = {userId}
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetTweets([FromQuery] Guid? userId)
        {
            var tweets = userId.HasValue ? _tweetRepository.GetTweetsByUserId(userId.Value) : _tweetRepository.GetTweets();

            return Ok(tweets.Select(tweet => new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content,
                CreatedAt = tweet.CreatedAt
            }));
        }


        // GET/api/tweets/{id}
        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetTweetById([FromRoute] Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
            {
                return NotFound();
            }

            return Ok(new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content,
                CreatedAt = tweet.CreatedAt
            });

        }

        // POST /api/tweets
        [HttpPost]
        public IActionResult CreateTweet([FromBody] CreateTweetDto createTweetDto)
        {
            if (string.IsNullOrWhiteSpace(createTweetDto.Content))
            {
                return BadRequest("Content is required.");
            }

            var user = _userRepository.GetUserById(createTweetDto.UserId);

            if (user == null)
            {
                return BadRequest("User does not exist.");
            }


            var createdTweet = _tweetRepository.AddTweet(new Tweet(createTweetDto.UserId, createTweetDto.Content));


            return Ok(new TweetDto
            {
                Id = createdTweet.Id,
                UserId = createdTweet.UserId,
                Content = createdTweet.Content,
                CreatedAt = createdTweet.CreatedAt
            });

        }


        [HttpPut("{id}")]
        public IActionResult UpdateTweet([FromRoute] Guid id, [FromBody] UpdateTweetDto updateTweetDto)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
            {
                return NotFound();
            }

            tweet.Content = updateTweetDto.Content;

            _tweetRepository.UpdateTweet(tweet);

            return Ok(new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content,
                CreatedAt = tweet.CreatedAt
            });
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute] Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
            {
                return NotFound();
            }

            var isDeleted = _tweetRepository.DeleteTweet(tweet);

            return Ok(isDeleted);
        }

    }

}
