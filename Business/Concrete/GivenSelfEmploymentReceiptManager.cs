using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class GivenSelfEmploymentReceiptManager : IGivenSelfEmploymentReceiptService
    {
        public IResult Add(GivenSelfEmploymentReceipt entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(GivenSelfEmploymentReceipt entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<GivenSelfEmploymentReceipt> Get(Expression<Func<GivenSelfEmploymentReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<GivenSelfEmploymentReceipt>> GetAll(Expression<Func<GivenSelfEmploymentReceipt, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(GivenSelfEmploymentReceipt entity)
        {
            throw new NotImplementedException();
        }
    }

}
