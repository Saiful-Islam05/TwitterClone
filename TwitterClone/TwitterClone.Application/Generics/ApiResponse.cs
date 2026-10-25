using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;

namespace TwitterClone.Application.Generics
{
    public class ApiResponse<TDto>
    {
        public bool Success { get; set; }
        public TDto? Data { get; set; } 

        public string Message { get; set; } = string.Empty;
    }

    public class  Verify
    {
        public void Run()
        {
            var res = new ApiResponse<TweetDto>();

            res.Success = true;
            res.Data = new TweetDto()
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Content = ""
            };


            var user = res.Data.UserId;
        }
    }

}
