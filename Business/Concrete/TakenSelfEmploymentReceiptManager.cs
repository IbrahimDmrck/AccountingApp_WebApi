using Business.Abstract;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class TakenSelfEmploymentReceiptManager : ITakenSelfEmploymentReceiptService
    {
        ITakenSelfEmploymentReceiptDal _takenSelfEmploymentReceiptDal;

        public TakenSelfEmploymentReceiptManager(ITakenSelfEmploymentReceiptDal takenSelfEmploymentReceiptDal)
        {
            _takenSelfEmploymentReceiptDal = takenSelfEmploymentReceiptDal;
        }

        public IResult Add(TakenSelfEmploymentReceipt entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(TakenSelfEmploymentReceipt entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<TakenSelfEmploymentReceipt> Get(Expression<Func<TakenSelfEmploymentReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TakenSelfEmploymentReceipt>> GetAll(Expression<Func<TakenSelfEmploymentReceipt, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TakenSelfEmploymentReceipt entity)
        {
            throw new NotImplementedException();
        }
    }

}
