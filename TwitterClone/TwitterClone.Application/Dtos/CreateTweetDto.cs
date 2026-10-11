using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Application.Dtos
{
    public class CreateTweetDto
    {
        public string Content { get; set; } = string.Empty;
        public Guid UserId { get; set; }
    }
}
