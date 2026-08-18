using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity,ILikable
    {
        private Guid _userid;
        private string _content;

        public Tweet(string content) : base(Guid.NewGuid())
        {
            _content = content;
        }

       public Tweet(Guid userId, string content): base(Guid.NewGuid())
        {
            _userid = userId;
            _content = content;
        }

        public Guid UserId
        {
            get { return _userid; }
            set { _userid = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public void AddContent(string content)
        {
            _content = content;
        }

        public void AddContent(Guid userId, string content)
        {
            _userid = UserId;
            _content = Content;
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Content: {Content}";
        }

        public bool CanBeLiked()
        {
            if(string.IsNullOrWhiteSpace(Content))
            {
                return false;
            }

            return true;
        }
    }
}
