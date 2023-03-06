using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TakenSelfEmploymentReceipt : IEntity
    {
        public int Id { get; set; }
        public string ReceiptName { get; set; }
        public DateTime Date { get; set; }
        public int WithholdingRate { get; set; }
        public int FundShareRate { get; set; }
        public int WithholdingId { get; set; }
        public int TotalDeductions { get; set; }
        public int ExactFee { get; set; }
        public int TotalReceived { get; set; }
        public string ServiceReason { get; set; }
    }
}
