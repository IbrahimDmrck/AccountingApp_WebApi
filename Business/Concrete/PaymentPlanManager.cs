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
    public class PaymentPlanManager : IPaymentPlanService
    {
        IPaymentPlanDal _paymentPlanDal;

        public PaymentPlanManager(IPaymentPlanDal paymentPlanDal)
        {
            _paymentPlanDal = paymentPlanDal;
        }

        public IResult Add(PaymentPlan entity)
        {
            _paymentPlanDal.Add(entity);
            return new SuccessResult(Messages.PaymentPlanAdded);
        }

        public IResult Delete(PaymentPlan entity)
        {
            _paymentPlanDal.Delete(entity);
            return new SuccessResult(Messages.PaymentPlanDeleted);
        }

        public IDataResult<PaymentPlan> Get(Expression<Func<PaymentPlan, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PaymentPlan>> GetAll(Expression<Func<PaymentPlan, bool>> filter = null)
        {
            return new SuccessDataResult<List<PaymentPlan>>(_paymentPlanDal.GetAll(), Messages.PaymentPlanListed);
        }

        public IDataResult<PaymentPlan> GetEntityById(int id)
        {
            return new SuccessDataResult<PaymentPlan>(_paymentPlanDal.Get(b => b.Id == id), Messages.PaymentPlanListed);
        }

        public IResult Update(PaymentPlan entity)
        {
            _paymentPlanDal.Update(entity);
            return new SuccessResult(Messages.PaymentPlanUUpdated);
        }
    }

}
