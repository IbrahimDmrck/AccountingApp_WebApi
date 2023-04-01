using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
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
            _takenSelfEmploymentReceiptDal.Add(entity);
            return new SuccessResult(Messages.TakenSelfEmploymentReceiptAdded);
        }

        public IResult Delete(TakenSelfEmploymentReceipt entity)
        {
            _takenSelfEmploymentReceiptDal.Delete(entity);
            return new SuccessResult(Messages.TakenSelfEmploymentReceiptDeleted);
        }

        public IDataResult<TakenSelfEmploymentReceipt> Get(Expression<Func<TakenSelfEmploymentReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TakenSelfEmploymentReceipt>> GetAll(Expression<Func<TakenSelfEmploymentReceipt, bool>> filter = null)
        {
            return new SuccessDataResult<List<TakenSelfEmploymentReceipt>>(_takenSelfEmploymentReceiptDal.GetAll(), Messages.TakenSelfEmploymentReceiptListed);
        }

        public IDataResult<TakenSelfEmploymentReceipt> GetEntityById(int id)
        {
            return new SuccessDataResult<TakenSelfEmploymentReceipt>(_takenSelfEmploymentReceiptDal.Get(b => b.Id == id), Messages.TakenSelfEmploymentReceiptListed);
        }

        public IResult Update(TakenSelfEmploymentReceipt entity)
        {
            _takenSelfEmploymentReceiptDal.Update(entity);
            return new SuccessResult(Messages.TakenSelfEmploymentReceiptUpdated);
        }
    }

}
