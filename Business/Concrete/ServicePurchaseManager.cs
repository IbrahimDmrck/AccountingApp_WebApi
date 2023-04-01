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
    public class ServicePurchaseManager : IServicePurchaseService
    {
        IServicePurchaseDal _servicePurchaseDal;

        public ServicePurchaseManager(IServicePurchaseDal servicePurchaseDal)
        {
            _servicePurchaseDal = servicePurchaseDal;
        }

        public IResult Add(ServicePurchase entity)
        {
            _servicePurchaseDal.Add(entity);
            return new SuccessResult(Messages.ServicePurchaseAdded);
        }

        public IResult Delete(ServicePurchase entity)
        {
            _servicePurchaseDal.Delete(entity);
            return new SuccessResult(Messages.ServicePurchaseDeleted);
        }

        public IDataResult<ServicePurchase> Get(Expression<Func<ServicePurchase, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ServicePurchase>> GetAll(Expression<Func<ServicePurchase, bool>> filter = null)
        {
            return new SuccessDataResult<List<ServicePurchase>>(_servicePurchaseDal.GetAll(), Messages.ServicePurchaseListed);
        }

        public IDataResult<ServicePurchase> GetEntityById(int id)
        {
            return new SuccessDataResult<ServicePurchase>(_servicePurchaseDal.Get(b => b.Id == id), Messages.ServicePurchaseListed);
        }

        public IResult Update(ServicePurchase entity)
        {
            _servicePurchaseDal.Update(entity);
            return new SuccessResult(Messages.ServicePurchaseUpdated);
        }
    }

}
