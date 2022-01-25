using Microsoft.EntityFrameworkCore;
using System;
using TaxiAplication;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiAplication.Interfaces;
using TaxiPersistance.NotesConfiguration;
using TaxiDomain;

namespace TaxiPersistance
{
    internal class CarDbContext:DbContext, ICarDbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarDbContext(DbContextOptions<CarDbContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CarConfiguraion());
            base.OnModelCreating(builder);
        }
    }
}
