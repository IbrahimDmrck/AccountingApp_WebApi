using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Materials : IEntity
    {
        public int Id { get; set; }
        public string  Description { get; set; }
        public string ManufacturerCode { get; set; }
        public string ShelfLife { get; set; }
        public string PlaceOfUs { get; set; }
        public bool  Status { get; set; }
        public int AdditionalTaxId { get; set; }
        public int VatRate { get; set; }
        public int Purchasing { get; set; }
        public int Sale { get; set; }
        public int Return { get; set; }
        public int RetailSale { get; set; }
        public int RetailReturn { get; set; }
        public int BrandId { get; set; }
        public int WithholdingId { get; set; }
        public int UnitSetId { get; set; }
        public int UnitBarcode { get; set; }
    }
}
