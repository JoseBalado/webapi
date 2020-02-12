using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("")]
    public class rootController : ControllerBase
    {
        [HttpGet]
        public string helloWorld()
        {
            return "Hello from Net Core";
        }
    }
}
