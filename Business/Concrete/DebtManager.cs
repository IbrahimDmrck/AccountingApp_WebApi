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
    public class DebtManager : IDebtService
    {

        IDebtDal _debtDal;

        public DebtManager(IDebtDal debtDal)
        {
            _debtDal = debtDal;
        }

        public IResult Add(Debt entity)
        {
            _debtDal.Add(entity);
            return new SuccessResult(Messages.DebtAdded);
        }

        public IResult Delete(Debt entity)
        {
            _debtDal.Delete(entity);
            return new SuccessResult(Messages.DebtDeleted);
        }

        public IDataResult<Debt> Get(Expression<Func<Debt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Debt>> GetAll(Expression<Func<Debt, bool>> filter = null)
        {
            return new SuccessDataResult<List<Debt>>(_debtDal.GetAll(), Messages.DebtListed);
        }

        public IDataResult<Debt> GetEntityById(int id)
        {
            return new SuccessDataResult<Debt>(_debtDal.Get(b => b.Id == id), Messages.DebtListed);
        }

        public IResult Update(Debt entity)
        {
            _debtDal.Update(entity);
            return new SuccessResult(Messages.DebtUpdated);
        }
    }

}
