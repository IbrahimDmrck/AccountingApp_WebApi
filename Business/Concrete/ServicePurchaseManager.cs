using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ServicePurchaseManager : IServicePurchaseService
    {
        public IResult Add(ServicePurchase entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(ServicePurchase entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ServicePurchase> Get(Expression<Func<ServicePurchase, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ServicePurchase>> GetAll(Expression<Func<ServicePurchase, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ServicePurchase entity)
        {
            throw new NotImplementedException();
        }
    }

}
