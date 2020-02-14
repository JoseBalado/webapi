using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using webapi.Models;

namespace webapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InsertData();
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void InsertData()
        {
            using (var context = new WebapiContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                // Adds an user
                var user = new User
                {
                    id = 35,
                    name = "My Books"
                };
                // context.User.Add(user);

                // Saves changes
                context.SaveChanges();
            }
        }

    }
}
