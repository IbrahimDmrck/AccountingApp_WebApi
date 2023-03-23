using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class MaterialManager : IMaterialService
    {
        public IResult Add(Materials entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Materials entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Materials> Get(Expression<Func<Materials, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Materials>> GetAll(Expression<Func<Materials, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Materials entity)
        {
            throw new NotImplementedException();
        }
    }

}
