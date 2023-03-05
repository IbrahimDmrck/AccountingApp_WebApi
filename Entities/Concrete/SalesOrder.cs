using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SalesOrder
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public int DeliveryId { get; set; }
        public int CurrentAccountId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string OrderType { get; set; }
        public int PaymentPlanId { get; set; }
        public string Description { get; set; }
        public int AdditionalTaxBase { get; set; }
        public int Quantity { get; set; }
        public int AdditionalTaxAmount { get; set; }
        public int  PendingAmount { get; set; }
        public int WithholdingId { get; set; }
        public string CPACode { get; set; }
        public string GTIPCode { get; set; }
        public string Country { get; set; }
        public int Vat { get; set; }
        public int Total { get; set; }
        public DateTime RequestDate { get; set; }
        public int PendingReserveAmount { get; set; }
        public bool Reserve { get; set; }
        public DateTime ReserveDate { get; set; }
        public int ReserveAmount { get; set; }

    }
}
