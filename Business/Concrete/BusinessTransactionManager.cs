using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class BusinessTransactionManager : IBusinessTransactionService
    {
        public IResult Add(BusinessTransaction entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BusinessTransaction entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BusinessTransaction> Get(Expression<Func<BusinessTransaction, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BusinessTransaction>> GetAll(Expression<Func<BusinessTransaction, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BusinessTransaction entity)
        {
            throw new NotImplementedException();
        }
    }

}
