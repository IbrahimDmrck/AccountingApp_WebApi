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
    public class SalesOrderManager : ISalesOrderService
    {
        ISalesOrderDal _salesOrderDal;

        public SalesOrderManager(ISalesOrderDal salesOrderDal)
        {
            _salesOrderDal = salesOrderDal;
        }

        public IResult Add(SalesOrder entity)
        {
            _salesOrderDal.Add(entity);
            return new SuccessResult(Messages.SalesOrderAdded);
        }

        public IResult Delete(SalesOrder entity)
        {
            _salesOrderDal.Delete(entity);
            return new SuccessResult(Messages.SalesOrderDeleted);
        }

        public IDataResult<SalesOrder> Get(Expression<Func<SalesOrder, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SalesOrder>> GetAll(Expression<Func<SalesOrder, bool>> filter = null)
        {
            return new SuccessDataResult<List<SalesOrder>>(_salesOrderDal.GetAll(), Messages.SalesOrderListed);
        }

        public IDataResult<SalesOrder> GetEntityById(int id)
        {
            return new SuccessDataResult<SalesOrder>(_salesOrderDal.Get(b => b.Id == id), Messages.SalesOrderListed);
        }

        public IResult Update(SalesOrder entity)
        {
            _salesOrderDal.Update(entity);
            return new SuccessResult(Messages.SalesOrderUpdated);
        }
    }

}
