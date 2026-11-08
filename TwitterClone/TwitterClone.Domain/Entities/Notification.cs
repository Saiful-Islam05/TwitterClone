using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public abstract class Notification : BaseEntity
    {
        private Guid _userId;
        private string _type = string.Empty ;
        private string _message = string.Empty;
        private bool _isRead;


        protected Notification() : base(Guid.NewGuid())
        {

        }
        protected Notification(string notificationType) : base(Guid.NewGuid())
        {
            _type = notificationType;
        }


        public User? User { get; set; }
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

        public string Message
        {
            get { return _message; }
            protected set { _message = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Type: {Type}, Message: {Message}, IsRead: {IsRead}";
        }

        public abstract string GetMessage();
    }
}