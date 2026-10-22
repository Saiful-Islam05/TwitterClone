namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        private Guid _userId;                     
        private Guid _tweetId;                   
        private DateTime _retweetedAt;            
        private string _comment = string.Empty;   

        public Guid UserId { get { return _userId; } }
        public Guid TweetId { get { return _tweetId; } }
        public DateTime RetweetedAt { get { return _retweetedAt; } }
        public string Comment { get { return _comment; } }

        private Retweet() { }   

        
        public Retweet(Guid userId, Guid tweetId, string comment = "") : base(userId)
        {
            _userId = userId;
            _tweetId = tweetId;
            _comment = comment;
            _retweetedAt = DateTime.UtcNow;
        }

       
        public void UpdateComment(string comment)
        {
            _comment = comment;
            MarkAsModified(_userId);   
        }
    }
}