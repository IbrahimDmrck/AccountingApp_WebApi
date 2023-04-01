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
    public class PurchasingMaterialManager : IPurchasingMaterialService
    {

        IPurchasingMaterialDal _purchasingMaterialDal;

        public PurchasingMaterialManager(IPurchasingMaterialDal purchasingMaterialDal)
        {
            _purchasingMaterialDal = purchasingMaterialDal;
        }

        public IResult Add(PurchasingMaterial entity)
        {
            _purchasingMaterialDal.Add(entity);
            return new SuccessResult(Messages.PurchasingMaterialAdded);
        }

        public IResult Delete(PurchasingMaterial entity)
        {
            _purchasingMaterialDal.Delete(entity);
            return new SuccessResult(Messages.PurchasingMaterialDeleted);
        }

        public IDataResult<PurchasingMaterial> Get(Expression<Func<PurchasingMaterial, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PurchasingMaterial>> GetAll(Expression<Func<PurchasingMaterial, bool>> filter = null)
        {
            return new SuccessDataResult<List<PurchasingMaterial>>(_purchasingMaterialDal.GetAll(), Messages.PurchasingMaterial);
        }

        public IDataResult<PurchasingMaterial> GetEntityById(int id)
        {
            return new SuccessDataResult<PurchasingMaterial>(_purchasingMaterialDal.Get(b => b.Id == id), Messages.PurchasingMaterial);
        }

        public IResult Update(PurchasingMaterial entity)
        {
            _purchasingMaterialDal.Update(entity);
            return new SuccessResult(Messages.PurchasingMaterialUpdated);
        }
    }

}
