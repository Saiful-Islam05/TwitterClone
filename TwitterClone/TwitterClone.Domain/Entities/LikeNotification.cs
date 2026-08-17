using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public LikeNotification(Guid likeByUserId) : base("Like")
        {
            LikeByUserId = likeByUserId;
        }
        public Guid LikeByUserId { get; set; }
        public void AddMessage(string message)
        {
            Message = message;
        }
        
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord} ------------- From LikeNotification Class! Notification Type: {Type}, Message: {Message}, IsRead: {IsRead}, LikeByUserId:{LikeByUserId}";
        }

        public override string GetMessage()
        {
            return $"From LikeNotification class User with ID {LikeByUserId} liked your post";
        }
        
    }
}
