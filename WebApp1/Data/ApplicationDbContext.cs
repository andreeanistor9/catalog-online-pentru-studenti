using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp1.Models;
namespace WebApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Curs> Curs{ get; set; }
        public DbSet<Nota> Nota{ get; set; }
      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}