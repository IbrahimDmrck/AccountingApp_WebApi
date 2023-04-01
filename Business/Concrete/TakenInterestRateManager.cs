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
    public class TakenInterestRateManager : ITakenInterestRateService
    {
        ITakenInterestRateDal _takenInterestRateDal;

        public TakenInterestRateManager(ITakenInterestRateDal takenInterestRateDal)
        {
            _takenInterestRateDal = takenInterestRateDal;
        }

        public IResult Add(TakenInterestRate entity)
        {
            _takenInterestRateDal.Add(entity);
            return new SuccessResult(Messages.TakenInterestRateAdded);
        }

        public IResult Delete(TakenInterestRate entity)
        {
            _takenInterestRateDal.Delete(entity);
            return new SuccessResult(Messages.TakenInterestRateDeleted);
        }

        public IDataResult<TakenInterestRate> Get(Expression<Func<TakenInterestRate, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TakenInterestRate>> GetAll(Expression<Func<TakenInterestRate, bool>> filter = null)
        {
            return new SuccessDataResult<List<TakenInterestRate>>(_takenInterestRateDal.GetAll(), Messages.TakenInterestRateListed);
        }

        public IDataResult<TakenInterestRate> GetEntityById(int id)
        {
            return new SuccessDataResult<TakenInterestRate>(_takenInterestRateDal.Get(b => b.Id == id), Messages.TakenInterestRateListed);
        }

        public IResult Update(TakenInterestRate entity)
        {
            _takenInterestRateDal.Update(entity);
            return new SuccessResult(Messages.TakenInterestRateUpdated);
        }
    }

}
