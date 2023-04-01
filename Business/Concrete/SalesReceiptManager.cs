using Business.Abstract;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class SalesReceiptManager : ISalesReceiptService
    {
        ISalesReceiptDal _salesReceiptDal;

        public SalesReceiptManager(ISalesReceiptDal salesReceiptDal)
        {
            _salesReceiptDal = salesReceiptDal;
        }

        public IResult Add(SalesReceipt entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SalesReceipt entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SalesReceipt> Get(Expression<Func<SalesReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SalesReceipt>> GetAll(Expression<Func<SalesReceipt, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SalesReceipt entity)
        {
            throw new NotImplementedException();
        }
    }

}
