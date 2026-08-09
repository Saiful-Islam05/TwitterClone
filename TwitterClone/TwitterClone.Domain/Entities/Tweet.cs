using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private Guid _authorId;
        private string _content;


        public Tweet()
        {
            _id = Guid.NewGuid();
        }
        public Guid Id
        {
            get { return _id; }
        }

        public Guid AuthorId
        {
            get { return _authorId; }
            set { _authorId = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}
