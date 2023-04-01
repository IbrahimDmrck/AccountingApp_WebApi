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
    public class CreditManager : ICreditService
    {

        ICreditDal _creditDal;

        public CreditManager(ICreditDal creditDal)
        {
            _creditDal = creditDal;
        }

        public IResult Add(Credit entity)
        {
            _creditDal.Add(entity);
            return new SuccessResult(Messages.CreditAdded);
        }

        public IResult Delete(Credit entity)
        {
            _creditDal.Delete(entity);
            return new SuccessResult(Messages.CreditDeleted);
        }

        public IDataResult<Credit> Get(Expression<Func<Credit, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Credit>> GetAll(Expression<Func<Credit, bool>> filter = null)
        {
            return new SuccessDataResult<List<Credit>>(_creditDal.GetAll(), Messages.CreditListed);
        }

        public IDataResult<Credit> GetEntityById(int id)
        {
            return new SuccessDataResult<Credit>(_creditDal.Get(b => b.Id == id), Messages.CreditListed);
        }

        public IResult Update(Credit entity)
        {
            _creditDal.Update(entity);
            return new SuccessResult(Messages.CreditUpdated);
        }
    }

}
