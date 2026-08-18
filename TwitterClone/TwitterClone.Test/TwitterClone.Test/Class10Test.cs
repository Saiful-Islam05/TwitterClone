using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Test
{
    public class Class10Test
    {
        public void Run()
        {
            var tweet = new Tweet("This is my first tweet");
            tweet.AddContent("This is my updated tweet content");

            ILikable likeableTweet = new Tweet("This is another tweet");

            Console.WriteLine(likeableTweet.CanBeLiked());
        }
    }
}
