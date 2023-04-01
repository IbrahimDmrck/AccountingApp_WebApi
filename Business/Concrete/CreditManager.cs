using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(Credit entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Credit> Get(Expression<Func<Credit, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Credit>> GetAll(Expression<Func<Credit, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Credit entity)
        {
            throw new NotImplementedException();
        }
    }

}
