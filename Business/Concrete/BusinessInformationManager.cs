using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class BusinessInformationManager : IBusinessInformationService
    {
        public IResult Add(BusinessInformation entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BusinessInformation entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BusinessInformation> Get(Expression<Func<BusinessInformation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BusinessInformation>> GetAll(Expression<Func<BusinessInformation, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BusinessInformation entity)
        {
            throw new NotImplementedException();
        }
    }

}
