using Business.Abstract;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CarrierCompanyManager : ICarrierCompanyService
    {
        ICarrierCompanyDal _carrierCompanyDal;

        public CarrierCompanyManager(ICarrierCompanyDal carrierCompanyDal)
        {
            _carrierCompanyDal = carrierCompanyDal;
        }

        public IResult Add(CarrierCompany entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CarrierCompany entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarrierCompany> Get(Expression<Func<CarrierCompany, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarrierCompany>> GetAll(Expression<Func<CarrierCompany, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarrierCompany entity)
        {
            throw new NotImplementedException();
        }
    }

}
