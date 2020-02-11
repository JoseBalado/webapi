using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/getsuers")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public User GetUsers()
        {
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
