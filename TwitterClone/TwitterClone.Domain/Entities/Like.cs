using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _likedAt;

        public Like()
        {
            _id = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }

        public DateTime LikedAt
        {
            get { return _likedAt; }
            set { _likedAt = value; }
        }
    }
}
