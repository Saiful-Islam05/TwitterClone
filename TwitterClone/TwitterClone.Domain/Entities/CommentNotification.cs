using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public CommentNotification(Guid commentByUserId) : base("Comment")
        {
            CommentByUserId = commentByUserId;
        }

        public Guid CommentByUserId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, CommentByUserId: {CommentByUserId}";
        }

        public override string GetMessage()
        {
            return $"From Comment Notification, User with ID {CommentByUserId} Commented your post";
        }
    }
}
