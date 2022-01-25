using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPersistance
{
    internal class DbInitialaser
    {
        public static void DbInitialise(CarDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
