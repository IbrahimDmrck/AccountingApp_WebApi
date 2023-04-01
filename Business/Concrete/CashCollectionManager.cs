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
    public class CashCollectionManager : ICashCollectionService
    {
        ICashCollectionDal _cashCollectionDal;

        public CashCollectionManager(ICashCollectionDal cashCollectionDal)
        {
            _cashCollectionDal = cashCollectionDal;
        }

        public IResult Add(CashCollection entity)
        {
            _cashCollectionDal.Add(entity);
            return new SuccessResult(Messages.CashCollectionAdded);
        }

        public IResult Delete(CashCollection entity)
        {
            _cashCollectionDal.Delete(entity);
            return new SuccessResult(Messages.CashCollectionDeleted);
        }

        public IDataResult<CashCollection> Get(Expression<Func<CashCollection, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CashCollection>> GetAll(Expression<Func<CashCollection, bool>> filter = null)
        {
            return new SuccessDataResult<List<CashCollection>>(_cashCollectionDal.GetAll(), Messages.CashCollectionListed);
        }

        public IDataResult<CashCollection> GetEntityById(int id)
        {
            return new SuccessDataResult<CashCollection>(_cashCollectionDal.Get(b => b.Id == id), Messages.CashCollectionListed);
        }

        public IResult Update(CashCollection entity)
        {
            _cashCollectionDal.Update(entity);
            return new SuccessResult(Messages.CashCollectionUpdated);
        }
    }

}
