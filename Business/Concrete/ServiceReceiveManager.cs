using Business.Abstract;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ServiceReceiveManager : IServiceReceiveService
    {
        IServiceReceiveDal _serviceReceiveDal;

        public ServiceReceiveManager(IServiceReceiveDal serviceReceiveDal)
        {
            _serviceReceiveDal = serviceReceiveDal;
        }

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
