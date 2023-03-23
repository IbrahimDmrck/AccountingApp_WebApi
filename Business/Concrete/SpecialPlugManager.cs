using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class SpecialPlugManager : ISpecialPlugService
    {
        public IResult Add(SpecialPlug entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SpecialPlug entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SpecialPlug> Get(Expression<Func<SpecialPlug, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SpecialPlug>> GetAll(Expression<Func<SpecialPlug, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SpecialPlug entity)
        {
            throw new NotImplementedException();
        }
    }

}
