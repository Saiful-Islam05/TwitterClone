using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _followedAt;


        public Follow()
        {
            _id = Guid.NewGuid();
        }
        public Guid Id
        {
            get { return _id; }
        }

        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
            set { _followingId = value; }
        }

        public DateTime FollowedAt
        {
            get { return _followedAt; }
            set { _followedAt = value; }
        }
    }
}
