using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class UnitSetManager : IUnitSetService
    {
        public IResult Add(UnitSet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(UnitSet entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<UnitSet> Get(Expression<Func<UnitSet, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UnitSet>> GetAll(Expression<Func<UnitSet, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UnitSet entity)
        {
            throw new NotImplementedException();
        }
    }

}
