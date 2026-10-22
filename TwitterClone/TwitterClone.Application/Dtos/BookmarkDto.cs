using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Application.Dtos
{
    public class BookmarkDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid TweetId { get; set; }
        public DateTime CreatedAt { get; set; }
        
    }
}
