using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                new { Id = 1, Name = "Saiful Islam", Handle = "@saiful" },
                new { Id = 2, Name = "Abdul Aziz", Handle = "@aziz" },
                new { Id = 3, Name = "Saifa Islam", Handle = "@saifa" }
            };

            return Ok(users);
        }
    }
}
