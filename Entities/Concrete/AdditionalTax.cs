using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AdditionalTax
    {
        public int Id { get; set; }
        public string  Description { get; set; }
        public string AdditionalTaxType { get; set; }
        public DateTime Date { get; set; }
        public int Rate { get; set; }
        public int Amount { get; set; }
        public int RateToBeCharged { get; set; }
        public int AmountToBeCollected { get; set; }
        public int UnitSetId { get; set; }
        public int DiscountAmount { get; set; }
        
    }
}
