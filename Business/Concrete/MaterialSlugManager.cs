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
    public class MaterialSlugManager : IMaterialSlugService
    {
        IMaterialSlugDal _materialSlugDal;

        public MaterialSlugManager(IMaterialSlugDal materialSlugDal)
        {
            _materialSlugDal = materialSlugDal;
        }

        public IResult Add(MaterialSlug entity)
        {
            _materialSlugDal.Add(entity);
            return new SuccessResult(Messages.MaterialSlugAdded);
        }

        public IResult Delete(MaterialSlug entity)
        {
            _materialSlugDal.Delete(entity);
            return new SuccessResult(Messages.MaterialSlugDeleted);
        }

        public IDataResult<MaterialSlug> Get(Expression<Func<MaterialSlug, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MaterialSlug>> GetAll(Expression<Func<MaterialSlug, bool>> filter = null)
        {
            return new SuccessDataResult<List<MaterialSlug>>(_materialSlugDal.GetAll(), Messages.MaterialSlugListed);
        }

        public IDataResult<MaterialSlug> GetEntityById(int id)
        {
            return new SuccessDataResult<MaterialSlug>(_materialSlugDal.Get(b => b.Id == id), Messages.MaterialSlugListed);
        }

        public IResult Update(MaterialSlug entity)
        {
            _materialSlugDal.Update(entity);
            return new SuccessResult(Messages.MaterialSlugUpdated);
        }
    }

}
