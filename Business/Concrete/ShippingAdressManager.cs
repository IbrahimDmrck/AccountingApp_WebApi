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
    public class ShippingAdressManager : IShippingAdressService
    {

        IShippingAdressDal _shippingAdressDal;

        public ShippingAdressManager(IShippingAdressDal shippingAdressDal)
        {
            _shippingAdressDal = shippingAdressDal;
        }

        public IResult Add(ShippingAdress entity)
        {
            _shippingAdressDal.Add(entity);
            return new SuccessResult(Messages.ShippingAdressAdded);
        }

        public IResult Delete(ShippingAdress entity)
        {
            _shippingAdressDal.Delete(entity);
            return new SuccessResult(Messages.ShippingAdressDeleted);
        }

        public IDataResult<ShippingAdress> Get(Expression<Func<ShippingAdress, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ShippingAdress>> GetAll(Expression<Func<ShippingAdress, bool>> filter = null)
        {
            return new SuccessDataResult<List<ShippingAdress>>(_shippingAdressDal.GetAll(), Messages.ShippingAdressListed);
        }

        public IDataResult<ShippingAdress> GetEntityById(int id)
        {
            return new SuccessDataResult<ShippingAdress>(_shippingAdressDal.Get(b => b.Id == id), Messages.ShippingAdressListed);
        }

        public IResult Update(ShippingAdress entity)
        {
            _shippingAdressDal.Update(entity);
            return new SuccessResult(Messages.ShippingAdressUpdated);
        }
    }

}
