using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(ShippingAdress entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ShippingAdress> Get(Expression<Func<ShippingAdress, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ShippingAdress>> GetAll(Expression<Func<ShippingAdress, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ShippingAdress entity)
        {
            throw new NotImplementedException();
        }
    }

}
