
using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly List<User> users = new()
        {
            new User
            {
                Id = 1,
                Name = "Mpho Raat",
                Email = "mpho@example.com",
                Age = 22
            }
        };

        private static int nextId = 2;

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);

            if (user == null)
                return NotFound(new { message = "User not found." });

            return Ok(user);
        }

        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            user.Id = nextId++;
            users.Add(user);

            return CreatedAtAction(
                nameof(GetUser),
                new { id = user.Id },
                user
            );
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Id == id);

            if (user == null)
                return NotFound(new { message = "User not found." });

            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            user.Age = updatedUser.Age;

            return Ok(new
            {
                message = "User updated successfully.",
                user
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);

            if (user == null)
                return NotFound(new { message = "User not found." });

            users.Remove(user);

            return Ok(new { message = "User deleted successfully." });
        }
    }
}
