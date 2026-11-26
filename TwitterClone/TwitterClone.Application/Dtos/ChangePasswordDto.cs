using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TwitterClone.Application.Dtos
{
    public class ChangePasswordDto
    {
        [Required]
        public required string CurrentPassword { get; set; }

        [Required]
        [MinLength(8)]
        public required string NewPassword { get; set; }
    }
}
