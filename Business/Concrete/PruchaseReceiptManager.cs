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
    public class PruchaseReceiptManager : IPruchaseReceiptService
    {
        IPruchaseReceiptDal _pruchaseReceiptDal;

        public PruchaseReceiptManager(IPruchaseReceiptDal pruchaseReceiptDal)
        {
            _pruchaseReceiptDal = pruchaseReceiptDal;
        }

        public IResult Add(PruchaseReceipt entity)
        {
            _pruchaseReceiptDal.Add(entity);
            return new SuccessResult(Messages.PruchaseReceiptAdded);
        }

        public IResult Delete(PruchaseReceipt entity)
        {
            _pruchaseReceiptDal.Delete(entity);
            return new SuccessResult(Messages.PruchaseReceiptDeleted);
        }

        public IDataResult<PruchaseReceipt> Get(Expression<Func<PruchaseReceipt, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PruchaseReceipt>> GetAll(Expression<Func<PruchaseReceipt, bool>> filter = null)
        {
            return new SuccessDataResult<List<PruchaseReceipt>>(_pruchaseReceiptDal.GetAll(), Messages.PruchaseReceiptListed);
        }

        public IDataResult<PruchaseReceipt> GetEntityById(int id)
        {
            return new SuccessDataResult<PruchaseReceipt>(_pruchaseReceiptDal.Get(b => b.Id == id), Messages.PruchaseReceiptListed);
        }

        public IResult Update(PruchaseReceipt entity)
        {
            _pruchaseReceiptDal.Update(entity);
            return new SuccessResult(Messages.PruchaseReceiptUpdated);
        }
    }

}
