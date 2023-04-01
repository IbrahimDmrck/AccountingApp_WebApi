using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
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
            _salesReceiptDal.Add(entity);
            return new SuccessResult(Messages.SalesReceiptAdded);
        }

        public IResult Delete(SalesReceipt entity)
        {
            _salesReceiptDal.Delete(entity);
            return new SuccessResult(Messages.SalesReceiptDeleted);
        }

        public IDataResult<SalesReceipt> Get(Expression<Func<SalesReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SalesReceipt>> GetAll(Expression<Func<SalesReceipt, bool>> filter = null)
        {
            return new SuccessDataResult<List<SalesReceipt>>(_salesReceiptDal.GetAll(), Messages.SalesReceiptListed);
        }

        public IDataResult<SalesReceipt> GetEntityById(int id)
        {
            return new SuccessDataResult<SalesReceipt>(_salesReceiptDal.Get(b => b.Id == id), Messages.SalesReceiptListed);
        }

        public IResult Update(SalesReceipt entity)
        {
            _salesReceiptDal.Update(entity);
            return new SuccessResult(Messages.SalesReceiptUpdated);
        }
    }

}
