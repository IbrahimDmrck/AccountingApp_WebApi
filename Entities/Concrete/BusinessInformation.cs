using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BusinessInformation
    {
        public int Id { get; set; }
        public int TaxAdministrationId { get; set; }
        public int PaymentPlanId { get; set; }
        public int BusinessTransactionId { get; set; }
        public int ValueAddedTaxNumber { get; set; }
        public int DiscountRate { get; set; }
        public int CarrierId { get; set; }
        public string IdentityNumber { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public string NameSurname { get; set; }
        public string PaymentType { get; set; }
    }
}
