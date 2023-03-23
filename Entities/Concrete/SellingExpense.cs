﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SellingExpense : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int VatRate { get; set; }
        public int UnitSetId { get; set; }
    }
}