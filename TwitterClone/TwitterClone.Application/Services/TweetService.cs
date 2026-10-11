using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Services
{
    public class TweetService : ITweetService
    {

        private readonly ITweetRepository _tweetRepository;
        private readonly IUserRepository _userRepository;
        public TweetService(ITweetRepository tweetRepository, IUserRepository userRepository)
        {
            _tweetRepository = tweetRepository;
            _userRepository = userRepository;
        }

        public TweetDto? CreateTweet(CreateTweetDto createTweetDto)
        {
            if (string.IsNullOrWhiteSpace(createTweetDto.Content))
            {
                return null;
            }

            var author = _userRepository.GetUserById(createTweetDto.UserId);    

            if (author == null)
            {
                return null;
            }


            var createdTweet = _tweetRepository.AddTweet(new Tweet(createTweetDto.UserId, createTweetDto.Content));


            return new TweetDto
            {
                Id = createdTweet.Id,
                UserId = createdTweet.UserId,
                Content = createdTweet.Content,
                CreatedAt = createdTweet.CreatedAt
            };
        }

        public bool DeleteTweet(Guid id)
        {
            throw new NotImplementedException();
        }

        public TweetDto GetTweetById(Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            return new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content,
                CreatedAt = tweet.CreatedAt
            };
        }

        public List<TweetDto> GetTweets()
        {
            throw new NotImplementedException();
        }

        public TweetDto UpdateTweet(Guid id, UpdateTweetDto updateTweetDto)
        {

            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
            {
                return null;
            }

            tweet.Content = updateTweetDto.Content;

            _tweetRepository.UpdateTweet(tweet);

            return new TweetDto
            {
                Id = tweet.Id,
                UserId = tweet.UserId,
                Content = tweet.Content,
                CreatedAt = tweet.CreatedAt
            };
        }
    }
}
