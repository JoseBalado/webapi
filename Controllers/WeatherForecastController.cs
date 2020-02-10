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
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public WeatherForecast GetUser()
        {
            var user = new WeatherForecast
            {
                name = "Jose",
                email = "jose@gmail.com",
                password = "password"
            };

            return user;
        }
    }
}
