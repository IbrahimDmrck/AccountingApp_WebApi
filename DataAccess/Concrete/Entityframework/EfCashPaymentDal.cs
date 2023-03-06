﻿using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public class EfCashPaymentDal : EfEntityRepositoryBase<CashPayment, AccountingContext>, ICashPaymentDal
    {
    }
}
