using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        public UsersController()
        {

        }


        [HttpGet]
        [Authorize]
        public IActionResult GetUsers()
        {

            return Ok(new List<object>
            { 
                new
                {
                    UserId = Guid.NewGuid(),
                    UserName = "user1",
                },
                new
                {
                    UserId = Guid.NewGuid(),
                    UserName = "user2",
                },
            });
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser()
        {
            return Ok(new
            {
                UserId = Guid.NewGuid(),
                UserName = "newuser",
            });
        }

        // /api/users/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                UserName = "user" + id.ToString(),
            });
        }

        // PUT/api/users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                UserName = "updateuser" + id.ToString()
            });
        }

        // I want to update only user phone number
        // PATCH /api/users/{id}/phonenNumber
        [HttpPatch("{id}/phoneNumber")]
        public IActionResult UpdateUserPhoneNumber([FromRoute] Guid id, [FromBody] string phoneNumber)
        {
            return Ok(new
            {
                UserId = id,
                PhoneNumber = phoneNumber
            });
        }

        // DELETE/api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult Deleteuser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                Message = "User deleted Successfully.",
            });
        }
    }
}
