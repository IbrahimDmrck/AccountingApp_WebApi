using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ServiceReceive
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int PaymentPlanId { get; set; }
        public int AdditionalTaxId { get; set; }
        public int VatRate { get; set; }
        public int VatSaleRate { get; set; }
        public int VatReturnRate { get; set; }
        public int UnitSetId { get; set; }
        public int WithholdingId { get; set; }
        public int ProvideOfServiceId { get; set; }
        public string DistributionType { get; set; }
    }
}
