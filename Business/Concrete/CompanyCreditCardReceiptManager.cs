using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(CompanyCreditCardReceipt entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CompanyCreditCardReceipt> Get(Expression<Func<CompanyCreditCardReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CompanyCreditCardReceipt>> GetAll(Expression<Func<CompanyCreditCardReceipt, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CompanyCreditCardReceipt entity)
        {
            throw new NotImplementedException();
        }
    }

}
