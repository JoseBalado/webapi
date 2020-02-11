using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("[action]/{id}")]
        public User getUser(int id)
        {
            Console.WriteLine("Get user number: " + id);
            var user = new User
            {
                name = "Jose",
                email = "jose@gmail.com",
                password = "password"
            };

            return user;
        }

        [HttpGet]
        [Route("[action]")]
        public List<User> getAllUsers()
        {
            Console.WriteLine("Get all users");

            var users = new List<User>
            {
                new User { name="Vithal Wadje",email="Mumbai@gmail.com",password="99999999999" },
                new User { name = "Sudhir Wadje", email = "Latur@gmail.com", password = "88888888888888888888" },
                new User { name = "Anil", email = "Delhi@gmail.com", password = "77777777777777777777" },
                new User { name = "Jose", email = "jose@gmail.com", password = "password" }
            };

            return users;
        }
    }
}
