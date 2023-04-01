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
    public class CarrierCompanyManager : ICarrierCompanyService
    {
        ICarrierCompanyDal _carrierCompanyDal;

        public CarrierCompanyManager(ICarrierCompanyDal carrierCompanyDal)
        {
            _carrierCompanyDal = carrierCompanyDal;
        }

        public IResult Add(CarrierCompany entity)
        {
            _carrierCompanyDal.Add(entity);
            return new SuccessResult(Messages.CarrierCompanyAdded);
        }

        public IResult Delete(CarrierCompany entity)
        {
            _carrierCompanyDal.Delete(entity);
            return new SuccessResult(Messages.CarrierCompanyDeleted);
        }

        public IDataResult<CarrierCompany> Get(Expression<Func<CarrierCompany, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarrierCompany>> GetAll(Expression<Func<CarrierCompany, bool>> filter = null)
        {
            return new SuccessDataResult<List<CarrierCompany>>(_carrierCompanyDal.GetAll(), Messages.CarrierCompanyListed);
        }

        public IDataResult<CarrierCompany> GetEntityById(int id)
        {
            return new SuccessDataResult<CarrierCompany>(_carrierCompanyDal.Get(b => b.Id == id), Messages.CarrierCompanyListed);
        }

        public IResult Update(CarrierCompany entity)
        {
            _carrierCompanyDal.Update(entity);
            return new SuccessResult(Messages.CarrierCompanyUpdated);
        }
    }

}
