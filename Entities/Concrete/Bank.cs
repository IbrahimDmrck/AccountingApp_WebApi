using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Bank : IEntity
    {
        public int Id { get; set; }

        public string BankName { get; set; }

        public string Branch { get; set; }
        public int AddressBookId { get; set; }
        public int BankAccountId { get; set; }
    }
}
