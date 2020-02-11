using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
            Console.WriteLine("User number: " + id);
            var user = new User
            {
                name = "Jose",
                email = "jose@gmail.com",
                password = "password"
            };

            return user;
        }
    }
}
