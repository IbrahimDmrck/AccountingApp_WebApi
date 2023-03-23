using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CompanyCreditCardReturnSlipManager : ICompanyCreditCardReturnSlipService
    {
        public IResult Add(CompanyCreditCardReturnSlip entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CompanyCreditCardReturnSlip entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CompanyCreditCardReturnSlip> Get(Expression<Func<CompanyCreditCardReturnSlip, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CompanyCreditCardReturnSlip>> GetAll(Expression<Func<CompanyCreditCardReturnSlip, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CompanyCreditCardReturnSlip entity)
        {
            throw new NotImplementedException();
        }
    }

}
