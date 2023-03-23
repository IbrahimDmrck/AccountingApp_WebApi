using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class AdditionalTaxManager : IAdditionalTaxService
    {
        public IResult Add(AdditionalTax entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(AdditionalTax entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AdditionalTax> Get(Expression<Func<AdditionalTax, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<AdditionalTax>> GetAll(Expression<Func<AdditionalTax, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(AdditionalTax entity)
        {
            throw new NotImplementedException();
        }
    }

}
