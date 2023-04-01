using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(CashPayment entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CashPayment> Get(Expression<Func<CashPayment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CashPayment>> GetAll(Expression<Func<CashPayment, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CashPayment entity)
        {
            throw new NotImplementedException();
        }
    }

}
