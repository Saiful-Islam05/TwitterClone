using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Application.Dtos
{
    public class TweetDto
    {
        public Guid Id { get; set; }          
        public string Content { get; set; } = string.Empty;  
        public Guid UserId { get; set; }     
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }   
    }
}
