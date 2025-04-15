using Microsoft.EntityFrameworkCore;
using Studentportal.web.Models.Entities;

namespace Studentportal.web.Data
{
    public class ApplicationDbContext : DbContext
    {
           public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
