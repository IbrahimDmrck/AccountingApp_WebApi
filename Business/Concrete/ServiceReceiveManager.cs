using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ServiceReceiveManager : IServiceReceiveService
    {
        public IResult Add(ServiceReceive entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(ServiceReceive entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ServiceReceive> Get(Expression<Func<ServiceReceive, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ServiceReceive>> GetAll(Expression<Func<ServiceReceive, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ServiceReceive entity)
        {
            throw new NotImplementedException();
        }
    }

}
