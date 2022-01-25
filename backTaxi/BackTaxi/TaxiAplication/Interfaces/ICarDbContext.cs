using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDomain;

namespace TaxiAplication.Interfaces
{
    public interface ICarDbContext
    {
        DbSet<Car> Cars { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
