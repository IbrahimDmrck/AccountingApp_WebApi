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
    public class CompanyCreditCardReceiptManager : ICompanyCreditCardReceiptService
    {
        ICompanyCreditCardReceiptDal _companyCreditCardReceiptDal;

        public CompanyCreditCardReceiptManager(ICompanyCreditCardReceiptDal companyCreditCardReceiptDal)
        {
            _companyCreditCardReceiptDal = companyCreditCardReceiptDal;
        }

        public IResult Add(CompanyCreditCardReceipt entity)
        {
            _companyCreditCardReceiptDal.Add(entity);
            return new SuccessResult(Messages.CompanyCreditCardReceiptAdded);
        }

        public IResult Delete(CompanyCreditCardReceipt entity)
        {
            _companyCreditCardReceiptDal.Delete(entity);
            return new SuccessResult(Messages.CompanyCreditCardReceiptDeleted);
        }

        public IDataResult<CompanyCreditCardReceipt> Get(Expression<Func<CompanyCreditCardReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CompanyCreditCardReceipt>> GetAll(Expression<Func<CompanyCreditCardReceipt, bool>> filter = null)
        {
            return new SuccessDataResult<List<CompanyCreditCardReceipt>>(_companyCreditCardReceiptDal.GetAll(), Messages.CompanyCreditCardReceiptUpdatedListed);
        }

        public IDataResult<CompanyCreditCardReceipt> GetEntityById(int id)
        {
            return new SuccessDataResult<CompanyCreditCardReceipt>(_companyCreditCardReceiptDal.Get(b => b.Id == id), Messages.CompanyCreditCardReceiptUpdatedListed);
        }

        public IResult Update(CompanyCreditCardReceipt entity)
        {
            _companyCreditCardReceiptDal.Update(entity);
            return new SuccessResult(Messages.CompanyCreditCardReceiptUpdated);
        }
    }

}
