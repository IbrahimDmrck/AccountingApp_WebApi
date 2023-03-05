using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CashCollection
    {
        public int Id { get; set; }
        public string PrlugName { get; set; }
        public DateTime Date { get; set; }
        public int CurrentAccountId { get; set; }
        public string Description { get; set; }
        public int Debt { get; set; }
        public int Cash { get; set; }
        public int ReceiptNo { get; set; }
        
    }
}
