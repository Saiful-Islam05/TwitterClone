using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Api.Extensions;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("/login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            var authResponse = _authService.Login(loginDto);

            if (authResponse != null)
            {
                return Ok(authResponse);
            }
            else
            {
                return Unauthorized();
            }
        }

        // POST /api/auth/change-password
        [Authorize]
        [HttpPost("change-password")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangePassword([FromBody] ChangePasswordDto changePasswordDto)
        {
            var changed = _authService.ChangePassword(User.GetUserId(), changePasswordDto);

            if (!changed)
            {
                return BadRequest(new { field = "currentPassword", message = "Current password is incorrect." });
            }

            return NoContent();
        }

    }
}
