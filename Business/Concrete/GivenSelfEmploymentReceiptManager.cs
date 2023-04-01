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
    public class GivenSelfEmploymentReceiptManager : IGivenSelfEmploymentReceiptService
    {
        IGivenSelfEmploymentReceiptDal _givenSelfEmploymentReceiptDal;

        public GivenSelfEmploymentReceiptManager(IGivenSelfEmploymentReceiptDal givenSelfEmploymentReceiptDal)
        {
            _givenSelfEmploymentReceiptDal = givenSelfEmploymentReceiptDal;
        }

        public IResult Add(GivenSelfEmploymentReceipt entity)
        {
            _givenSelfEmploymentReceiptDal.Add(entity);
            return new SuccessResult(Messages.GivenSelfEmploymentReceiptAdded);
        }

        public IResult Delete(GivenSelfEmploymentReceipt entity)
        {
            _givenSelfEmploymentReceiptDal.Delete(entity);
            return new SuccessResult(Messages.GivenSelfEmploymentReceiptDeleted);
        }

        public IDataResult<GivenSelfEmploymentReceipt> Get(Expression<Func<GivenSelfEmploymentReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<GivenSelfEmploymentReceipt>> GetAll(Expression<Func<GivenSelfEmploymentReceipt, bool>> filter = null)
        {
            return new SuccessDataResult<List<GivenSelfEmploymentReceipt>>(_givenSelfEmploymentReceiptDal.GetAll(), Messages.GivenSelfEmploymentReceiptListed);
        }

        public IDataResult<GivenSelfEmploymentReceipt> GetEntityById(int id)
        {
            return new SuccessDataResult<GivenSelfEmploymentReceipt>(_givenSelfEmploymentReceiptDal.Get(b => b.Id == id), Messages.GivenSelfEmploymentReceiptListed);
        }

        public IResult Update(GivenSelfEmploymentReceipt entity)
        {
            _givenSelfEmploymentReceiptDal.Update(entity);
            return new SuccessResult(Messages.GivenSelfEmploymentReceiptUpdated);
        }
    }

}
