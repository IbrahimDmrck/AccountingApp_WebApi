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
    public class BusinessTransactionManager : IBusinessTransactionService
    {
        IBusinessTransactionDal _businessTransactionDal;

        public BusinessTransactionManager(IBusinessTransactionDal businessTransactionDal)
        {
            _businessTransactionDal = businessTransactionDal;
        }

        public IResult Add(BusinessTransaction entity)
        {
            _businessTransactionDal.Add(entity);
            return new SuccessResult(Messages.BusinessTransactionAdded);
        }

        public IResult Delete(BusinessTransaction entity)
        {
            _businessTransactionDal.Delete(entity);
            return new SuccessResult(Messages.BusinessTransactionDeleted);
        }

        public IDataResult<BusinessTransaction> Get(Expression<Func<BusinessTransaction, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BusinessTransaction>> GetAll(Expression<Func<BusinessTransaction, bool>> filter = null)
        {
            return new SuccessDataResult<List<BusinessTransaction>>(_businessTransactionDal.GetAll(), Messages.BusinessTransactionListed);
        }

        public IDataResult<BusinessTransaction> GetEntityById(int id)
        {
            return new SuccessDataResult<BusinessTransaction>(_businessTransactionDal.Get(b => b.Id == id), Messages.BusinessTransactionListed);
        }

        public IResult Update(BusinessTransaction entity)
        {
            _businessTransactionDal.Update(entity);
            return new SuccessResult(Messages.BusinessTransactionUpdated);
        }
    }

}
