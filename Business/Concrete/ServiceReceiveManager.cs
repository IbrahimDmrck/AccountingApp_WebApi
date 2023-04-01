using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
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
            _serviceReceiveDal.Add(entity);
            return new SuccessResult(Messages.ServiceReceiveAdded);
        }

        public IResult Delete(ServiceReceive entity)
        {
            _serviceReceiveDal.Delete(entity);
            return new SuccessResult(Messages.ServiceReceiveDeleted);
        }

        public IDataResult<ServiceReceive> Get(Expression<Func<ServiceReceive, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ServiceReceive>> GetAll(Expression<Func<ServiceReceive, bool>> filter = null)
        {
            return new SuccessDataResult<List<ServiceReceive>>(_serviceReceiveDal.GetAll(), Messages.ServiceReceiveListed);
        }

        public IDataResult<ServiceReceive> GetEntityById(int id)
        {
            return new SuccessDataResult<ServiceReceive>(_serviceReceiveDal.Get(b => b.Id == id), Messages.ServiceReceiveListed);
        }

        public IResult Update(ServiceReceive entity)
        {
            _serviceReceiveDal.Update(entity);
            return new SuccessResult(Messages.ServiceReceiveUpdated);
        }
    }

}
