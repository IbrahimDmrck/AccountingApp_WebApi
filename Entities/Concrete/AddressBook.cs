using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AddressBook : IEntity
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string CityCode { get; set; }
        public string CountyCode { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string CountyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AdditionalPhoneNumber { get; set; }
        public string ShortAddress { get; set; }

    }
}
