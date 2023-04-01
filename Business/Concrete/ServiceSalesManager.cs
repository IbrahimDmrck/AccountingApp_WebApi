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
    public class ServiceSalesManager : IServiceSalesService
    {
        IServiceSalesDal _serviceSalesDal;

        public ServiceSalesManager(IServiceSalesDal serviceSalesDal)
        {
            _serviceSalesDal = serviceSalesDal;
        }

        public IResult Add(ServiceSales entity)
        {
            _serviceSalesDal.Add(entity);
            return new SuccessResult(Messages.ServiceSalesAdded);
        }

        public IResult Delete(ServiceSales entity)
        {
            _serviceSalesDal.Delete(entity);
            return new SuccessResult(Messages.ServiceSalesDeleted);
        }

        public IDataResult<ServiceSales> Get(Expression<Func<ServiceSales, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ServiceSales>> GetAll(Expression<Func<ServiceSales, bool>> filter = null)
        {
            return new SuccessDataResult<List<ServiceSales>>(_serviceSalesDal.GetAll(), Messages.ServiceSalesListed);
        }

        public IDataResult<ServiceSales> GetEntityById(int id)
        {
            return new SuccessDataResult<ServiceSales>(_serviceSalesDal.Get(b => b.Id == id), Messages.ServiceSalesListed);
        }

        public IResult Update(ServiceSales entity)
        {
            _serviceSalesDal.Update(entity);
            return new SuccessResult(Messages.ServiceSalesUpdated);
        }
    }

}
