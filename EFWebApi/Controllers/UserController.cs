using EFWebApi.Context;
using EFWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFWebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        TestDbContext context = new TestDbContext();


        [HttpGet("getUsersById")]
        public async Task<User> GetUserById(int Id) {
            {
                //List<User> user = new List<User>();
                

                //return await context.Users.FindAsync(Id);
                return await context.Users.FindAsync(Id);

            }
            
        }

        [HttpGet("getName")]
        public  string GetUserName()
        {
            {
                //List<User> user = new List<User>();
                return  "sunil chhatbar";
            }

        }
    }
}
