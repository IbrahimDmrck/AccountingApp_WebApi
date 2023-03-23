using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class PurchasingMaterialManager : IPurchasingMaterialService
    {
        public IResult Add(PurchasingMaterial entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(PurchasingMaterial entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<PurchasingMaterial> Get(Expression<Func<PurchasingMaterial, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PurchasingMaterial>> GetAll(Expression<Func<PurchasingMaterial, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(PurchasingMaterial entity)
        {
            throw new NotImplementedException();
        }
    }

}
