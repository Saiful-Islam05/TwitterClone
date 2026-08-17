using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
        public Follow() : base(Guid.NewGuid())
        {

        }
        
        private Guid _followerId;
        private Guid _followingId;
      
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
     
    }
}
