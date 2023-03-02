using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CurrentAccount
    {
        public int CurrentAccountId { get; set; }
        public int BusinessInformationId { get; set; }
        public int AddressBookId { get; set; }
        public string Appellation { get; set; }
        public string CurrentAccountName { get; set; }
        public string InternetBusinessCode { get; set; }
        public bool Status { get; set; }
    }
}
