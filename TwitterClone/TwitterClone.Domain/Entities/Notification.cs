using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
<<<<<<< HEAD
    public abstract class Notification : BaseEntity
    {
       
        private Guid _userId;
        private string _type;
        private string _message;
        private bool _isRead;

        public Notification(string notificationType) : base(Guid.NewGuid())
        {
            _type = notificationType;
        }
        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        protected string Message
        {
            get { return _message; }
            set { _message = value; }
        }
=======
    public class Notification
    {
        private Guid _id;
        private Guid _recipientId;
        private Guid _senderId;
        private string _type;
        private string _content;
        private bool _isRead;
        private DateTime _createdAt;


        public Guid Id
        {
            get { return _id; }
        }

        public Guid RecipientId
        {
            get { return _recipientId; }
        }

        public Guid SenderId
        {
            get { return _senderId; }
        }

        public string Type
        {
            get { return _type; }
        }

        //If Content need.So we can have a setter for it
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        //It will change after read so we need to have a setter for it
>>>>>>> e8c22baae033aff7016f7940437a69c312b6baaa
        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

<<<<<<< HEAD
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Type: {Type}, Message: {Message},IsRead: {IsRead}";
        }

        /*
        public string GetNotificationInfo()
        {
            return $"UserId: {_userId}, NotificationType: {_type}";
        }
        */
        public abstract string GetMessage();
     
=======
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

>>>>>>> e8c22baae033aff7016f7940437a69c312b6baaa
    }
}
