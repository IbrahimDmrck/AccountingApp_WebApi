using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(SalesDiscount entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SalesDiscount> Get(Expression<Func<SalesDiscount, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SalesDiscount>> GetAll(Expression<Func<SalesDiscount, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SalesDiscount entity)
        {
            throw new NotImplementedException();
        }
    }

}
