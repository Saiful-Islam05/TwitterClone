using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class Comment : BaseEntity
    {
        private Guid _userId;
        private Guid _tweetId;
        private string _content = string.Empty;

        public Guid UserId { get { return _userId; } }
        public Guid TweetId { get { return _tweetId; } }
        public string Content { get { return _content; } }
        public User? User { get; private set; }
        public Tweet? Tweet { get; private set; }

        // EF Core-এর জন্য
        private Comment() { }

        public Comment(Guid userId, Guid tweetId, string content) : base(userId)
        {
            _userId = userId;
            _tweetId = tweetId;
            _content = content;
        }
    }
}
