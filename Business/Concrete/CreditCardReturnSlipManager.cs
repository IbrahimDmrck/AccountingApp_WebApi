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
    public class CreditCardReturnSlipManager : ICreditCardReturnSlipService
    {
        ICreditCardReturnSlipDal _creditCardReturnSlipDal;

        public CreditCardReturnSlipManager(ICreditCardReturnSlipDal creditCardReturnSlipDal)
        {
            _creditCardReturnSlipDal = creditCardReturnSlipDal;
        }

        public IResult Add(CreditCardReturnSlip entity)
        {
            _creditCardReturnSlipDal.Add(entity);
            return new SuccessResult(Messages.CreditCardReturnSlipAdded);
        }

        public IResult Delete(CreditCardReturnSlip entity)
        {
            _creditCardReturnSlipDal.Delete(entity);
            return new SuccessResult(Messages.CreditCardReturnSlipDeleted);
        }

        public IDataResult<CreditCardReturnSlip> Get(Expression<Func<CreditCardReturnSlip, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CreditCardReturnSlip>> GetAll(Expression<Func<CreditCardReturnSlip, bool>> filter = null)
        {
            return new SuccessDataResult<List<CreditCardReturnSlip>>(_creditCardReturnSlipDal.GetAll(), Messages.CreditCardReturnSlipListed);
        }

        public IDataResult<CreditCardReturnSlip> GetEntityById(int id)
        {
            return new SuccessDataResult<CreditCardReturnSlip>(_creditCardReturnSlipDal.Get(b => b.Id == id), Messages.CreditCardReturnSlipListed);
        }

        public IResult Update(CreditCardReturnSlip entity)
        {
            _creditCardReturnSlipDal.Update(entity);
            return new SuccessResult(Messages.CreditCardReturnSlipUpdated);
        }
    }

}
