using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PaymentPlan
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool  Status { get; set; }
        public int InterestRate { get; set; }
        public string PaymentType { get; set; }
        public int BankAccountId { get; set; }
    }
}
