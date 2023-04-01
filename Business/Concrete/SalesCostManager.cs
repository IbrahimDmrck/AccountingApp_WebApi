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
    public class SalesCostManager : ISalesCostService
    {

        ISalesCostDal _salesCostDal;

        public SalesCostManager(ISalesCostDal salesCostDal)
        {
            _salesCostDal = salesCostDal;
        }

        public IResult Add(SalesCost entity)
        {
            _salesCostDal.Add(entity);
            return new SuccessResult(Messages.SalesCostAdded);
        }

        public IResult Delete(SalesCost entity)
        {
            _salesCostDal.Delete(entity);
            return new SuccessResult(Messages.SalesCostDeleted);
        }

        public IDataResult<SalesCost> Get(Expression<Func<SalesCost, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SalesCost>> GetAll(Expression<Func<SalesCost, bool>> filter = null)
        {
            return new SuccessDataResult<List<SalesCost>>(_salesCostDal.GetAll(), Messages.SalesCostListed);
        }

        public IDataResult<SalesCost> GetEntityById(int id)
        {
            return new SuccessDataResult<SalesCost>(_salesCostDal.Get(b => b.Id == id), Messages.SalesCostListed);
        }

        public IResult Update(SalesCost entity)
        {
            _salesCostDal.Update(entity);
            return new SuccessResult(Messages.SalesCostUpdated);
        }
    }

}
