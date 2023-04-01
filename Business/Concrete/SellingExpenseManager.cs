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
    public class SellingExpenseManager : ISellingExpenseService
    {
        ISellingExpenseDal _sellingExpenseDal;

        public SellingExpenseManager(ISellingExpenseDal sellingExpenseDal)
        {
            _sellingExpenseDal = sellingExpenseDal;
        }

        public IResult Add(SellingExpense entity)
        {
            _sellingExpenseDal.Add(entity);
            return new SuccessResult(Messages.SellingExpenseAdded);
        }

        public IResult Delete(SellingExpense entity)
        {
            _sellingExpenseDal.Delete(entity);
            return new SuccessResult(Messages.SellingExpenseDeleted);
        }

        public IDataResult<SellingExpense> Get(Expression<Func<SellingExpense, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SellingExpense>> GetAll(Expression<Func<SellingExpense, bool>> filter = null)
        {
            return new SuccessDataResult<List<SellingExpense>>(_sellingExpenseDal.GetAll(), Messages.SellingExpenseListed);
        }

        public IDataResult<SellingExpense> GetEntityById(int id)
        {
            return new SuccessDataResult<SellingExpense>(_sellingExpenseDal.Get(b => b.Id == id), Messages.SellingExpenseListed);
        }

        public IResult Update(SellingExpense entity)
        {
            _sellingExpenseDal.Update(entity);
            return new SuccessResult(Messages.SellingExpenseUpdated);
        }
    }

}
