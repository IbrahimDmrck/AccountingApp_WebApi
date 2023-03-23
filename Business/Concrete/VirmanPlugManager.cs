using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class VirmanPlugManager : IVirmanPlugService
    {
        public IResult Add(VirmanPlug entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(VirmanPlug entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<VirmanPlug> Get(Expression<Func<VirmanPlug, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<VirmanPlug>> GetAll(Expression<Func<VirmanPlug, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(VirmanPlug entity)
        {
            throw new NotImplementedException();
        }
    }

}
