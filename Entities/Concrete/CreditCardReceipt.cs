using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CreditCardReceipt : IEntity
    {
        public int Id { get; set; }
        public string ReceiptName { get; set; }
        public int CurrentAccountId { get; set; }
        public int BankId { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public int PaymentPlanId { get; set; }
        public int CreditCardNumber { get; set; }
        public int BatchNumber { get; set; }
        public int ConfirmationNumber { get; set; }
    }
}
