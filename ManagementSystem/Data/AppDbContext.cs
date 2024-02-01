using ManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Data
{
    public class AppDbContext : IdentityDbContext<DbUser, DbRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Organization> Organizations { get; set; }
    }
}
