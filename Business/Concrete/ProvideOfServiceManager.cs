using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ProvideOfServiceManager : IProvideOfServiceService
    {
        public IResult Add(ProvideOfService entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(ProvideOfService entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ProvideOfService> Get(Expression<Func<ProvideOfService, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProvideOfService>> GetAll(Expression<Func<ProvideOfService, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ProvideOfService entity)
        {
            throw new NotImplementedException();
        }
    }

}
