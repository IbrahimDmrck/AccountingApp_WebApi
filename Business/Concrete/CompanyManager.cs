using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        public IResult Add(Company entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Company entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Company> Get(Expression<Func<Company, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Company>> GetAll(Expression<Func<Company, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Company entity)
        {
            throw new NotImplementedException();
        }
    }

}
