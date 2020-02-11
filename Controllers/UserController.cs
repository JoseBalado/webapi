using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api")]
    public class UserController : ControllerBase
    {
         static volatile List<User> users = new List<User>
         {
              new User { id = 1, name="Vithal Wadje",email="Mumbai@gmail.com",password="99999999999" },
              new User { id = 2, name = "Sudhir Wadje", email = "Latur@gmail.com", password = "88888888888888888888" },
              new User { id = 3, name = "Anil", email = "Delhi@gmail.com", password = "77777777777777777777" },
              new User { id = 4, name = "Jose", email = "jose@gmail.com", password = "password" }
         };

        [HttpGet]
        [Route("[action]/{id}")]
        public User getUser(int id)
        {
            Console.WriteLine("Get user number: " + id);

            var user = users.Single(user => user.id == id);
            Console.WriteLine(JsonSerializer.Serialize(user));

            return user;
        }

        [HttpGet]
        [Route("[action]")]
        public List<User> getAllUsers()
        {
            Console.WriteLine("Get all users");

            return users;
        }

        [HttpPost]
        [Route("[action]")]
        public User postUser(User user)
        {
            Console.WriteLine("Post user: " + JsonSerializer.Serialize(user));
            users.Add(user);
            return user;
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public User deleteUser(int id)
        {
            Console.WriteLine("Delete user: " + id);
            var user = users.SingleOrDefault(user => user.id == id);
            users.Remove(user);
            return user;
        }
    }
}
