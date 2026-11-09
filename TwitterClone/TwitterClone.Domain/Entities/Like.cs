namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity    
    {
        private Guid _userId;         
        private Guid _tweetId;        
        private DateTime _likedAt;

        private Like() { }

        public Guid UserId { get { return _userId; } }
        public Guid TweetId { get { return _tweetId; } }
        public DateTime LikedAt { get { return _likedAt; } }   
        public User? user { get; private set;}
        public Tweet? tweet { get; private set; }

       

     
        public Like(Guid userId, Guid tweetId) : base(userId)
        {
            _userId = userId;
            _tweetId = tweetId;
            _likedAt = DateTime.UtcNow;  
        }
    }
}