using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    internal class User
    {
        // Unique identifier for the user
        private Guid _id;

        //Private fields for user properties
        private string _firstName;
        private string _lastName;
        private string _email;

        // Constructor to initialize the user with a unique identifier
        public User()
        {
            _id = Guid.NewGuid();
        }

        // Public properties to access user information

        public Guid Id
        {
            get { return _id; }
        }

        // Public property for the user's first name
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

    }
}
