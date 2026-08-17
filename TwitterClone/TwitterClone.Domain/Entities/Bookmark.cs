using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
        public Bookmark() : base(Guid.NewGuid())
        {

        }

        private Guid _userId;
        private Guid _tweetId;
        
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
    }
}
