using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MaterialSlug : IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ReceiptName { get; set; }
        public string MaterialType { get; set; }
        public int MaterialId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int UnitSetId { get; set; }
        public int Amount { get; set; }
        public int AdditionalTaxBase { get; set; }
        public int AdditionalTaxAmount { get; set; }
    }
}
