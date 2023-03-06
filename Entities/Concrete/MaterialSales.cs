using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MaterialSales : IEntity
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public int UnitSetId { get; set; }
        public int CurrentAccontId { get; set; }
        public int PaymentPlanId { get; set; }
        public int BusinessTransactionId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int DeliveryCode { get; set; }
        public int DeliveryDay { get; set; }
    }
}
