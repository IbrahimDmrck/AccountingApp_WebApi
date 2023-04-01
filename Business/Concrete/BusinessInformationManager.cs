using Business.Abstract;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class BusinessInformationManager : IBusinessInformationService
    {
        IBusinessInformationDal _businessInformationDal;

        public BusinessInformationManager(IBusinessInformationDal businessInformationDal)
        {
            _businessInformationDal = businessInformationDal;
        }

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
