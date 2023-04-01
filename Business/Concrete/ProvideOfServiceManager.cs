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
    public class ProvideOfServiceManager : IProvideOfServiceService
    {
        IProvideOfServiceDal _provideOfServiceDal;

        public ProvideOfServiceManager(IProvideOfServiceDal provideOfServiceDal)
        {
            _provideOfServiceDal = provideOfServiceDal;
        }

        public IResult Add(ProvideOfService entity)
        {
            _provideOfServiceDal.Add(entity);
            return new SuccessResult(Messages.ProvideOfServiceAdded);
        }

        public IResult Delete(ProvideOfService entity)
        {
            _provideOfServiceDal.Delete(entity);
            return new SuccessResult(Messages.ProvideOfServiceDeleted);
        }

        public IDataResult<ProvideOfService> Get(Expression<Func<ProvideOfService, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProvideOfService>> GetAll(Expression<Func<ProvideOfService, bool>> filter = null)
        {
            return new SuccessDataResult<List<ProvideOfService>>(_provideOfServiceDal.GetAll(), Messages.ProvideOfServiceListed);
        }

        public IDataResult<ProvideOfService> GetEntityById(int id)
        {
            return new SuccessDataResult<ProvideOfService>(_provideOfServiceDal.Get(b => b.Id == id), Messages.ProvideOfServiceListed);
        }

        public IResult Update(ProvideOfService entity)
        {
            _provideOfServiceDal.Update(entity);
            return new SuccessResult(Messages.ProvideOfServiceUpdated);
        }
    }

}
