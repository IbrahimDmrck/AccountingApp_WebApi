using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarrierCompany : IEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public int AddressBookId { get; set; }
        public string InstitutionType { get; set; }
        public string TrackingSite { get; set; }
        public string WebAddress { get; set; }

    }
}
