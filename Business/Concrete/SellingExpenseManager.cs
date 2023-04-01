using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(SellingExpense entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SellingExpense> Get(Expression<Func<SellingExpense, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SellingExpense>> GetAll(Expression<Func<SellingExpense, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SellingExpense entity)
        {
            throw new NotImplementedException();
        }
    }

}
