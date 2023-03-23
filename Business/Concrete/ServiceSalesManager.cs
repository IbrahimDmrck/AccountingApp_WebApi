using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ServiceSalesManager : IServiceSalesService
    {
        public IResult Add(ServiceSales entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(ServiceSales entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ServiceSales> Get(Expression<Func<ServiceSales, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ServiceSales>> GetAll(Expression<Func<ServiceSales, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ServiceSales entity)
        {
            throw new NotImplementedException();
        }
    }

}
