using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _recipientId;
        private Guid _senderId;
        private string _type;
        private string _content;
        private bool _isRead;
        private DateTime _createdAt;


        public Notification()
        {
            _id = Guid.NewGuid();
        }


        public Guid Id
        {
            get { return _id; }
        }

        public Guid RecipientId
        {
            get { return _recipientId; }
            set { _recipientId = value; }
        }

        public Guid SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        //If Content need.So we can have a setter for it
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        //It will change after read so we need to have a setter for it
        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

    }
}
