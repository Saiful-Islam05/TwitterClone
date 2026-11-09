using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;
using TwitterClone.Infrastructure.Persistence;

namespace TwitterClone.Infrastructure.Repositories
{
    public class TweetRepository : ITweetRepository
    {
        private readonly TwitterCloneDbContext? _context;

        public TweetRepository(TwitterCloneDbContext? context)
        {
            _context = context;
        }
       
        public Tweet AddTweet(Tweet tweet)
        {
            //_tweets.Add(tweet);
            _context?.Tweets.Add(tweet);
            _context?.SaveChanges();
            return tweet;
        }
        public Tweet UpdateTweet(Tweet tweet)
        {
            //_tweets.RemoveAll(t => t.Id == tweet.Id);
            //_tweets.Add(tweet);

            _context?.Tweets.Update(tweet);
            _context?.SaveChanges();
            return tweet;
        }
        public bool DeleteTweet(Tweet tweet)
        {
            _context?.Tweets.Remove(tweet);
            _context?.SaveChanges();
            return true;
        }
        
        public Tweet? GetTweetById(Guid id)
        {
            return _context?.Tweets.SingleOrDefault(t => t.Id == id);
        }
        public List<Tweet> GetTweets()
        {
            return _context?.Tweets.ToList() ?? new List<Tweet>();
        }

        public List<Tweet> GetTweetsByUserId(Guid userId)
        {
            return _context?.Tweets.Where(t => t.UserId == userId).ToList() ?? new List<Tweet>();
        }

        public bool DeleteTweet(Guid id)
        {
            var tweet = GetTweetById(id);
            if (tweet == null) return false;

            _context?.Tweets.Remove(tweet);
            _context?.SaveChanges();
            return true;
        }
    }
}
