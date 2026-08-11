using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        public Message(string content) : base(Guid.NewGuid())
        {
            _content = content;
        }

        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sentAt;
        private bool _isRead;
      
        public Guid SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
            set { _receiverId = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public DateTime SentAt
        {
            get { return _sentAt; }
            set { _sentAt = value; }
        }

        // to Show Read receipt. So we can have a setter for it.
        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

    }
}
