using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class PurchasingMaterial : IEntity
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
