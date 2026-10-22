using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity, IFollowable, INotifiable
    {
        
        private string _firstName = string.Empty;  
        private string _lastName = string.Empty;
        private string _email = string.Empty;
        private string? _phoneNumber;              

        public User() : base(Guid.NewGuid())
        {

        }

      
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

       
        public string? PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private List<Guid> _followers = new List<Guid>();
        public List<Guid> _inCommingNotification = new List<Guid>();

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord},FirstName: {FirstName},LastName: {LastName},Email: {Email},PhoneNumber: {PhoneNumber}";
        }

        public void Follow(Guid userId)
        {
            if (!_followers.Contains(userId))
            {
                _followers.Add(userId);
            }
        }

        public void Unfollow(Guid userId)
        {
            if (_followers.Contains(userId))
            {
                _followers.Remove(userId);
            }
        }

        public void AddNotification(Guid notificationId)
        {
            if (!_inCommingNotification.Contains(notificationId))
            {
                _inCommingNotification.Add(notificationId);
            }
        }
    }
}