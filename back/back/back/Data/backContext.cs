using back.Models;
using Microsoft.EntityFrameworkCore;

namespace back.Data
{
    public class backContext:DbContext
    {
        public backContext(DbContextOptions<backContext> options)
           : base(options)
        {

        }

        public DbSet<City> City { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
