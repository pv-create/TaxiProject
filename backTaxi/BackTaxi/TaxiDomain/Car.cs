using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDomain
{
    public class Car
    {
        public Guid Id { get; set; }
        public Guid DriverId { get; set; }
        public string Marka { get; set; }
        public int Level { get; set; }
        public string CarNumber { get; set; }
    }
}
