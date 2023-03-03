using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UnitSet
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string BaseUnitCode { get; set; }
        public string BaseUnitCodeDescription { get; set; }
        public int Multiplier { get; set; }
        public int Divisor { get; set; }
    }
}
