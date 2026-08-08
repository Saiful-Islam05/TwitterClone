using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sentAt;
        private bool _isRead;

        
        public Guid Id
        {
            get { return _id; }
        }
        public Guid SenderId
        {
            get { return _senderId; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
        }

        // If Content will Edit/Delete feature.
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public DateTime SentAt
        {
            get { return _sentAt; }
        }

        // to Show Read receipt. So we can have a setter for it.
        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

    }
}
