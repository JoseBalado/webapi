using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi
{
  public class WebapiContext : DbContext
  {
    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=webapi_database;user=dotnetuser;password=dotnetpassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<User>(entity =>
      {
        entity.HasKey(e => e.id);
      });
    }
  }
}