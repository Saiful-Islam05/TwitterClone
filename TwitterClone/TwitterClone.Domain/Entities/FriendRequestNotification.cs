using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid commentByUserId) : base("FriendRequest")
        {
            FriendRequestByUserId = commentByUserId;
        }

        public Guid FriendRequestByUserId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }


    }
}
