using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(MaterialSlug entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<MaterialSlug> Get(Expression<Func<MaterialSlug, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MaterialSlug>> GetAll(Expression<Func<MaterialSlug, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MaterialSlug entity)
        {
            throw new NotImplementedException();
        }
    }

}
