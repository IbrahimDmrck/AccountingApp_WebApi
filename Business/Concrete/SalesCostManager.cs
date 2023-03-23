using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class SalesCostManager : ISalesCostService
    {
        public IResult Add(SalesCost entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SalesCost entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SalesCost> Get(Expression<Func<SalesCost, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SalesCost>> GetAll(Expression<Func<SalesCost, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SalesCost entity)
        {
            throw new NotImplementedException();
        }
    }

}
