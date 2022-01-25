using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaxiDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace TaxiPersistance.NotesConfiguration
{
    internal class CarConfiguraion:IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> typeBuilder)
        {
            typeBuilder.HasKey(car=>car.Id);
            typeBuilder.HasIndex(car=>car.Id).IsUnique();
            typeBuilder.Property(car => car.CarNumber).HasMaxLength(20);
        }
    }
}
