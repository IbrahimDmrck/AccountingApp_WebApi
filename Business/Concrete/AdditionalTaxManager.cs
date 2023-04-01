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
    public class AdditionalTaxManager : IAdditionalTaxService
    {

        IAdditionalTaxDal _additionalTaxDal;

        public AdditionalTaxManager(IAdditionalTaxDal additionalTaxDal)
        {
            _additionalTaxDal = additionalTaxDal;
        }

        public IResult Add(AdditionalTax entity)
        {
           _additionalTaxDal.Add(entity);
            return new SuccessResult(Messages.AdditionalTaxAdded);
        }

        public IResult Delete(AdditionalTax entity)
        {
            _additionalTaxDal.Delete(entity);
            return new SuccessResult(Messages.AdditionalTaxDeleted);
        }

        public IDataResult<AdditionalTax> Get(Expression<Func<AdditionalTax, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<AdditionalTax>> GetAll(Expression<Func<AdditionalTax, bool>> filter = null)
        {
            return new SuccessDataResult<List<AdditionalTax>>(_additionalTaxDal.GetAll(), Messages.AdditionalTaxListed);
        }

        public IDataResult<AdditionalTax> GetEntityById(int id)
        {
            return new SuccessDataResult<AdditionalTax>(_additionalTaxDal.Get(b => b.Id == id), Messages.AdditionalTaxListed);
        }

        public IResult Update(AdditionalTax entity)
        {
            _additionalTaxDal.Update(entity);
            return new SuccessResult(Messages.AdditionalTaxUpdated);
        }
    }

}
