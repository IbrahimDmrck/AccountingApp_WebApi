using Business.Abstract;
using Core.CrossCuttingconcerns.Caching;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CaseManager : ICaseService
    {
        public IResult Add(Case entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Case entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Case> Get(Expression<Func<Case, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Case>> GetAll(Expression<Func<Case, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Case entity)
        {
            throw new NotImplementedException();
        }
    }

}
