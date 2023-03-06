using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class PruchaseReceipt : IEntity
    {
        public int Id { get; set; }
        public string ReceiptName { get; set; }
        public int CurrentAccountId { get; set; }
        public string SalesReceiptType { get; set; }
        public int MaterialsId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int UnitSetId { get; set; }
        public int Vat { get; set; }
        public int Total { get; set; }
        public int VATExemptionCode { get; set; }
        public int CPACode { get; set; }
        public int GTIPCode { get; set; }
        public string Country { get; set; }
        public int ShippingAddressId { get; set; }
        public int ReceiptNumber { get; set; }
        public int DeliveryId { get; set; }
        public int CarrierId { get; set; }
        public int PackageParcelNumber { get; set; }
        public string TransportType { get; set; }
        public DateTime ShippingDate { get; set; }
    }
}
