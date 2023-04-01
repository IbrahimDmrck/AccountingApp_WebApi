using Business.Abstract;
using Core.Utilities.Result.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class PaymentPlanManager : IPaymentPlanService
    {
        IPaymentPlanDal _paymentPlanDal;

        public PaymentPlanManager(IPaymentPlanDal paymentPlanDal)
        {
            _paymentPlanDal = paymentPlanDal;
        }

        public IResult Add(PaymentPlan entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(PaymentPlan entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<PaymentPlan> Get(Expression<Func<PaymentPlan, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PaymentPlan>> GetAll(Expression<Func<PaymentPlan, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(PaymentPlan entity)
        {
            throw new NotImplementedException();
        }
    }

}
