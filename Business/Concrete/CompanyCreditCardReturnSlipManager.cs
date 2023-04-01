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
    public class CompanyCreditCardReturnSlipManager : ICompanyCreditCardReturnSlipService
    {
        ICompanyCreditCardReturnSlipDal _companyCreditCardReturnSlipDal;

        public CompanyCreditCardReturnSlipManager(ICompanyCreditCardReturnSlipDal companyCreditCardReturnSlipDal)
        {
            _companyCreditCardReturnSlipDal = companyCreditCardReturnSlipDal;
        }

        public IResult Add(CompanyCreditCardReturnSlip entity)
        {
            _companyCreditCardReturnSlipDal.Add(entity);
            return new SuccessResult(Messages.CompanyCreditCardReturnSlipAdded);
        }

        public IResult Delete(CompanyCreditCardReturnSlip entity)
        {
            _companyCreditCardReturnSlipDal.Delete(entity);
            return new SuccessResult(Messages.CompanyCreditCardReturnSlipDeleted);
        }

        public IDataResult<CompanyCreditCardReturnSlip> Get(Expression<Func<CompanyCreditCardReturnSlip, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CompanyCreditCardReturnSlip>> GetAll(Expression<Func<CompanyCreditCardReturnSlip, bool>> filter = null)
        {
            return new SuccessDataResult<List<CompanyCreditCardReturnSlip>>(_companyCreditCardReturnSlipDal.GetAll(), Messages.CompanyCreditCardReturnSlipListed);
        }

        public IDataResult<CompanyCreditCardReturnSlip> GetEntityById(int id)
        {
            return new SuccessDataResult<CompanyCreditCardReturnSlip>(_companyCreditCardReturnSlipDal.Get(b => b.Id == id), Messages.CompanyCreditCardReturnSlipListed);
        }

        public IResult Update(CompanyCreditCardReturnSlip entity)
        {
            _companyCreditCardReturnSlipDal.Update(entity);
            return new SuccessResult(Messages.CompanyCreditCardReturnSlipUpdated);
        }
    }

}
