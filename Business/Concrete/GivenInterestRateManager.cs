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
    public class GivenInterestRateManager : IGivenInterestRateService
    {

        IGivenInterestRateDal _givenInterestRateDal;

        public GivenInterestRateManager(IGivenInterestRateDal givenInterestRateDal)
        {
            _givenInterestRateDal = givenInterestRateDal;
        }

        public IResult Add(GivenInterestRate entity)
        {
            _givenInterestRateDal.Add(entity);
            return new SuccessResult(Messages.GivenInterestRateAdded);
        }

        public IResult Delete(GivenInterestRate entity)
        {
            _givenInterestRateDal.Delete(entity);
            return new SuccessResult(Messages.GivenInterestRateDeleted);
        }

        public IDataResult<GivenInterestRate> Get(Expression<Func<GivenInterestRate, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<GivenInterestRate>> GetAll(Expression<Func<GivenInterestRate, bool>> filter = null)
        {
            return new SuccessDataResult<List<GivenInterestRate>>(_givenInterestRateDal.GetAll(), Messages.GivenInterestRateListed);
        }

        public IDataResult<GivenInterestRate> GetEntityById(int id)
        {
            return new SuccessDataResult<GivenInterestRate>(_givenInterestRateDal.Get(b => b.Id == id), Messages.GivenInterestRateListed);
        }

        public IResult Update(GivenInterestRate entity)
        {
            _givenInterestRateDal.Update(entity);
            return new SuccessResult(Messages.GivenInterestRateUpdated);
        }
    }

}
