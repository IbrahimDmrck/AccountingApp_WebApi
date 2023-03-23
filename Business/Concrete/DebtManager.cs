using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class DebtManager : IDebtService
    {
        public IResult Add(Debt entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Debt entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Debt> Get(Expression<Func<Debt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Debt>> GetAll(Expression<Func<Debt, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Debt entity)
        {
            throw new NotImplementedException();
        }
    }

}
