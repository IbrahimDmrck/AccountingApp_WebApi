using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(CreditCardReceipt entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CreditCardReceipt> Get(Expression<Func<CreditCardReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CreditCardReceipt>> GetAll(Expression<Func<CreditCardReceipt, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CreditCardReceipt entity)
        {
            throw new NotImplementedException();
        }
    }

}
