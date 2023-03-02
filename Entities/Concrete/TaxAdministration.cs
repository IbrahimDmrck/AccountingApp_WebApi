using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TaxAdministration
    {
        public int Id { get; set; }
        public string TaxAdministrationName { get; set; }
        public int AddressBookId { get; set; }
    }
}
