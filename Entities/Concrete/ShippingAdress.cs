﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ShippingAdress
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
        public int AddressBookId { get; set; }
    }
}
