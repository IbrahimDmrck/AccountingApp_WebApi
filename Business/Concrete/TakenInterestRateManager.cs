using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class TakenInterestRateManager : ITakenInterestRateService
    {
        public IResult Add(TakenInterestRate entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(TakenInterestRate entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<TakenInterestRate> Get(Expression<Func<TakenInterestRate, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TakenInterestRate>> GetAll(Expression<Func<TakenInterestRate, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TakenInterestRate entity)
        {
            throw new NotImplementedException();
        }
    }

}
