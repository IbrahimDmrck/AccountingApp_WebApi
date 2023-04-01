using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(TaxAdministration entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<TaxAdministration> Get(Expression<Func<TaxAdministration, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaxAdministration>> GetAll(Expression<Func<TaxAdministration, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TaxAdministration entity)
        {
            throw new NotImplementedException();
        }
    }

}
