using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;

namespace TwitterClone.Api.Controllers
{
    // api/users
    [ApiController]
    [Route("api/[controller]")]
    
    public class UsersController: ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
   


        // api/users
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
        }


        // api/users
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser([FromBody] CreateUserDto createUserDto)
        {
            var createdUser = _userService.CreateUser(createUserDto);

            if(createdUser is null)
            {
                return BadRequest("A Error happen during create user.");
            }

            return Ok(createdUser);
        }

        // /api/users/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
            var user = _userService.GetUserById(id);

            if(user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT/api/users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserDto updateUserDto)
        {
            var user = _userService.UpdateUser(id, updateUserDto);

            if(user == null)
            {
                return NotFound();
            }


           return Ok(user);
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
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            var isDeleted = _userService.DeleteUser(id);

            if(isDeleted==false)
            {
                return NotFound();
            }

            return Ok(isDeleted);
        }
    }
}
