using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class PruchaseReceiptManager : IPruchaseReceiptService
    {
        public IResult Add(PruchaseReceipt entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(PruchaseReceipt entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<PruchaseReceipt> Get(Expression<Func<PruchaseReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PruchaseReceipt>> GetAll(Expression<Func<PruchaseReceipt, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(PruchaseReceipt entity)
        {
            throw new NotImplementedException();
        }
    }

}
