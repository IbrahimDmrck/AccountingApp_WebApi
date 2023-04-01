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
    public class TaxAdministrationManager : ITaxAdministrationService
    {
        ITaxAdministrationDal _taxAdministrationDal;

        public TaxAdministrationManager(ITaxAdministrationDal taxAdministrationDal)
        {
            _taxAdministrationDal = taxAdministrationDal;
        }

        public IResult Add(TaxAdministration entity)
        {
            _taxAdministrationDal.Add(entity);
            return new SuccessResult(Messages.TaxAdministrationAdded);
        }

        public IResult Delete(TaxAdministration entity)
        {
            _taxAdministrationDal.Delete(entity);
            return new SuccessResult(Messages.TaxAdministrationDeleted);
        }

        public IDataResult<TaxAdministration> Get(Expression<Func<TaxAdministration, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaxAdministration>> GetAll(Expression<Func<TaxAdministration, bool>> filter = null)
        {
            return new SuccessDataResult<List<TaxAdministration>>(_taxAdministrationDal.GetAll(), Messages.TaxAdministrationListed);
        }

        public IDataResult<TaxAdministration> GetEntityById(int id)
        {
            return new SuccessDataResult<TaxAdministration>(_taxAdministrationDal.Get(b => b.Id == id), Messages.TaxAdministrationListed);
        }

        public IResult Update(TaxAdministration entity)
        {
            _taxAdministrationDal.Update(entity);
            return new SuccessResult(Messages.TaxAdministrationUpdated);
        }
    }

}
