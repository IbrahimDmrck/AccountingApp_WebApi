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
    public class CreditCardReceiptManager : ICreditCardReceiptService
    {
        ICreditCardReceiptDal _creditCardReceiptDal;

        public CreditCardReceiptManager(ICreditCardReceiptDal creditCardReceiptDal)
        {
            _creditCardReceiptDal = creditCardReceiptDal;
        }

        public IResult Add(CreditCardReceipt entity)
        {
            _creditCardReceiptDal.Add(entity);
            return new SuccessResult(Messages.CreditCardReceiptAdded);
        }

        public IResult Delete(CreditCardReceipt entity)
        {
            _creditCardReceiptDal.Delete(entity);
            return new SuccessResult(Messages.CreditCardReceiptDeleted);
        }

        public IDataResult<CreditCardReceipt> Get(Expression<Func<CreditCardReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CreditCardReceipt>> GetAll(Expression<Func<CreditCardReceipt, bool>> filter = null)
        {
            return new SuccessDataResult<List<CreditCardReceipt>>(_creditCardReceiptDal.GetAll(), Messages.CreditCardReceiptListed);
        }

        public IDataResult<CreditCardReceipt> GetEntityById(int id)
        {
            return new SuccessDataResult<CreditCardReceipt>(_creditCardReceiptDal.Get(b => b.Id == id), Messages.CreditCardReceiptListed);
        }

        public IResult Update(CreditCardReceipt entity)
        {
            _creditCardReceiptDal.Update(entity);
            return new SuccessResult(Messages.CreditCardReceiptUpdated);
        }
    }

}
