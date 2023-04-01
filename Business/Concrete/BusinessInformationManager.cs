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
    public class BusinessInformationManager : IBusinessInformationService
    {
        IBusinessInformationDal _businessInformationDal;

        public BusinessInformationManager(IBusinessInformationDal businessInformationDal)
        {
            _businessInformationDal = businessInformationDal;
        }

        public IResult Add(BusinessInformation entity)
        {
            _businessInformationDal.Add(entity);
            return new SuccessResult(Messages.BusinessInformationAdded);
        }

        public IResult Delete(BusinessInformation entity)
        {
            _businessInformationDal.Delete(entity);
            return new SuccessResult(Messages.BusinessInformationDeleted);
        }

        public IDataResult<BusinessInformation> Get(Expression<Func<BusinessInformation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BusinessInformation>> GetAll(Expression<Func<BusinessInformation, bool>> filter = null)
        {
            return new SuccessDataResult<List<BusinessInformation>>(_businessInformationDal.GetAll(), Messages.BusinessInformationListed);
        }

        public IDataResult<BusinessInformation> GetEntityById(int id)
        {
            return new SuccessDataResult<BusinessInformation>(_businessInformationDal.Get(b => b.Id == id), Messages.BusinessInformationListed);
        }

        public IResult Update(BusinessInformation entity)
        {
            _businessInformationDal.Update(entity);
            return new SuccessResult(Messages.BusinessInformationUpdated);
        }
    }

}
