using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Utilities.Extensions
{
    public static class TweetExtensions
    {
        public static bool IsPopular(this Tweet tweet)
        {
            if(tweet == null)
            {
                return false;
            }
            else if (tweet.Likes >= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
