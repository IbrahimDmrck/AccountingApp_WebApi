using Business.Abstract;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CreditCardReturnSlipManager : ICreditCardReturnSlipService
    {
        ICreditCardReturnSlipDal _creditCardReturnSlipDal;

        public CreditCardReturnSlipManager(ICreditCardReturnSlipDal creditCardReturnSlipDal)
        {
            _creditCardReturnSlipDal = creditCardReturnSlipDal;
        }

        public IResult Add(CreditCardReturnSlip entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CreditCardReturnSlip entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CreditCardReturnSlip> Get(Expression<Func<CreditCardReturnSlip, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CreditCardReturnSlip>> GetAll(Expression<Func<CreditCardReturnSlip, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CreditCardReturnSlip entity)
        {
            throw new NotImplementedException();
        }
    }

}
