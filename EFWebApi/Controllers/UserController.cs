
using EFWebApi.Context;
using EFWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        EFWebApiDbContext _context = new EFWebApiDbContext();
        [HttpGet("whoAmI")]
        public string GetUserName()
        {
            {
                //List<User> user = new List<User>();
                return "I am sunil chhatbar - a full stack developer.";
            }
        }

        // GET: api/users
        [HttpGet("api/users")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _context.Users.ToList();
        }
        [HttpGet("getUsersById")]
        public async Task<User> GetUserById(int Id)
        {
            {
                //List<User> user = new List<User>();

                //return await context.Users.FindAsync(Id);
                return await _context.Users.FindAsync(Id);

            }

        }
        // GET: api/users/{id}
        [HttpGet("api/users/{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
        // POST: api/users
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        // PUT: api/users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            return NoContent();
        }


    }
}
