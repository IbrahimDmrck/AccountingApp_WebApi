using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(GivenInterestRate entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<GivenInterestRate> Get(Expression<Func<GivenInterestRate, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<GivenInterestRate>> GetAll(Expression<Func<GivenInterestRate, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(GivenInterestRate entity)
        {
            throw new NotImplementedException();
        }
    }

}
