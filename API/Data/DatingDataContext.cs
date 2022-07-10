using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DatingDataContext : DbContext
    {
        public DatingDataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}
