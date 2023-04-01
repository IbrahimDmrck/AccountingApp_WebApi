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
    public class SalesDiscountManager : ISalesDiscountService
    {

        ISalesDiscountDal _salesDiscountDal;

        public SalesDiscountManager(ISalesDiscountDal salesDiscountDal)
        {
            _salesDiscountDal = salesDiscountDal;
        }

        public IResult Add(SalesDiscount entity)
        {
            _salesDiscountDal.Add(entity);
            return new SuccessResult(Messages.SalesDiscountAdded);
        }

        public IResult Delete(SalesDiscount entity)
        {
            _salesDiscountDal.Delete(entity);
            return new SuccessResult(Messages.SalesDiscountDeleted);
        }

        public IDataResult<SalesDiscount> Get(Expression<Func<SalesDiscount, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SalesDiscount>> GetAll(Expression<Func<SalesDiscount, bool>> filter = null)
        {
            return new SuccessDataResult<List<SalesDiscount>>(_salesDiscountDal.GetAll(), Messages.SalesDiscountListed);
        }

        public IDataResult<SalesDiscount> GetEntityById(int id)
        {
            return new SuccessDataResult<SalesDiscount>(_salesDiscountDal.Get(b => b.Id == id), Messages.SalesDiscountListed);
        }

        public IResult Update(SalesDiscount entity)
        {
            _salesDiscountDal.Update(entity);
            return new SuccessResult(Messages.SalesDiscountUpdated);
        }
    }

}
