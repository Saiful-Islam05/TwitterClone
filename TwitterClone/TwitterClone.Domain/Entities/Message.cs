namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity  
    {
        private Guid _senderId;                  
        private Guid _receiverId;            
        private string _content = string.Empty;  
        private DateTime _sentAt;               
        private bool _isRead;                   

        public Guid SenderId { get { return _senderId; } }
        public Guid ReceiverId { get { return _receiverId; } }
        public string Content { get { return _content; } }
        public DateTime SentAt { get { return _sentAt; } }
        public bool IsRead { get { return _isRead; } }

        private Message() { }   

       
        public Message(Guid senderId, Guid receiverId, string content) : base(senderId)
        {
            _senderId = senderId;
            _receiverId = receiverId;
            _content = content;
            _sentAt = DateTime.UtcNow;
            _isRead = false;                
        }

     
        public void UpdateContent(string content)
        {
            _content = content;              
            MarkAsModified(_senderId);       
        }

        
        public void MarkAsRead()
        {
            _isRead = true;
            MarkAsModified(_receiverId);     
        }
    }
}