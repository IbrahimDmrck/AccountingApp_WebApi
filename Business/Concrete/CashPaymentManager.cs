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
    public class CashPaymentManager : ICashPaymentService
    {
        ICashPaymentDal _cashPaymentDal;

        public CashPaymentManager(ICashPaymentDal cashPaymentDal)
        {
            _cashPaymentDal = cashPaymentDal;
        }

        public IResult Add(CashPayment entity)
        {
            _cashPaymentDal.Add(entity);
            return new SuccessResult(Messages.CashPaymentAdded);
        }

        public IResult Delete(CashPayment entity)
        {
            _cashPaymentDal.Delete(entity);
            return new SuccessResult(Messages.CashPaymentDeleted);
        }

        public IDataResult<CashPayment> Get(Expression<Func<CashPayment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CashPayment>> GetAll(Expression<Func<CashPayment, bool>> filter = null)
        {
            return new SuccessDataResult<List<CashPayment>>(_cashPaymentDal.GetAll(), Messages.CashPaymentListed);
        }

        public IDataResult<CashPayment> GetEntityById(int id)
        {
            return new SuccessDataResult<CashPayment>(_cashPaymentDal.Get(b => b.Id == id), Messages.CashPaymentListed);
        }

        public IResult Update(CashPayment entity)
        {
            _cashPaymentDal.Update(entity);
            return new SuccessResult(Messages.CashPaymentUpdated);
        }
    }

}
