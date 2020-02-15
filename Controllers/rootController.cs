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
    [Route("")]
    public class rootController : ControllerBase
    {
        private readonly WebapiContext _context;

        public rootController(WebapiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public string helloWorld()
        {
            var user = new User
            {
                id = 36,
                name = "My Books"
            };
            // _context.User.Add(user);

            // Saves changes
            _context.SaveChanges();

            return "Hello from Net Core";
        }
    }
}
