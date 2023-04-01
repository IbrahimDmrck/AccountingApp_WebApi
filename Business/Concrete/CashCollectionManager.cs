using Business.Abstract;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CashCollectionManager : ICashCollectionService
    {
        ICashCollectionDal _cashCollectionDal;

        public CashCollectionManager(ICashCollectionDal cashCollectionDal)
        {
            _cashCollectionDal = cashCollectionDal;
        }

        public IResult Add(CashCollection entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CashCollection entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CashCollection> Get(Expression<Func<CashCollection, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CashCollection>> GetAll(Expression<Func<CashCollection, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CashCollection entity)
        {
            throw new NotImplementedException();
        }
    }

}
