using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Case
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }
        public bool Status { get; set; }
        public string PrivateCode { get; set; }
        public string AuthorizationCode { get; set; }
        public string Address { get; set; }
        public string CollectionTotal { get; set; }
        public string PaymentsTotal { get; set; }
        public string CaseBalance { get; set; }
        public string Workplace { get; set; }
    }
}
