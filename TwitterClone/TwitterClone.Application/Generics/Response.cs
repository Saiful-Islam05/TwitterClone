using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;

namespace TwitterClone.Application.Generics
{
    public class Response
    {
        public bool Success { get; set; }
        public object? Data { get; set; }  //Upcasting
    }

    public class Test
    {
        public void Run()
        {
            var res = new Response();

            res.Success = true;

            res.Data = new TweetDto()
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                Content = ""
            };  //Upcasting

            TweetDto tweet = (TweetDto)res.Data;  //Downcasting
        }
    }



}
