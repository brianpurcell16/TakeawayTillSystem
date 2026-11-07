using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTillApp.Shared;

namespace TillsPOSSystem.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;

        }

        [HttpPost("login")]
        public async Task<IActionResult> GetUser([FromBody] UserModel request)
        {
            if (request == null)
            {
                return BadRequest("User data is null.");
            }
            var user = await _context.Employees.FirstOrDefaultAsync(u => u.Username == request.Username && u.Password == request.Password);

            if (user == null)
            {
                return Unauthorized("Invalid username or password.");
            }

            return Ok(new { user.EmpID, user.Username, user.Rank});

        }
    }
}
