using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class SalesOrderManager : ISalesOrderService
    {
        public IResult Add(SalesOrder entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SalesOrder entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SalesOrder> Get(Expression<Func<SalesOrder, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SalesOrder>> GetAll(Expression<Func<SalesOrder, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SalesOrder entity)
        {
            throw new NotImplementedException();
        }
    }

}
