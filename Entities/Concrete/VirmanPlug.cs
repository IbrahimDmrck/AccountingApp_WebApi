using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class VirmanPlug
    {
        public int Id { get; set; }
        public string ReceiptName { get; set; }
        public DateTime Date { get; set; }
        public int CurrentAccountId { get; set; }
        public string Description { get; set; }
        public int Debit { get; set; }
        public int Ready { get; set; }
        public int PaymentPlanId { get; set; }
        public int ReceiptNo { get; set; }
    }
}
