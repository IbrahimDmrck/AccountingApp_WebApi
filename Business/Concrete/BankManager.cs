using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BankManager : IBankService
    {
        IBankDal _bankDal;

        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
        }

        public IResult Add(Bank entity)
        {
            _bankDal.Add(entity);
            return new SuccessResult(Messages.BankAdded);
        }

        public IResult Delete(Bank entity)
        {
            _bankDal.Delete(entity);
            return new SuccessResult(Messages.BankDeleted);
        }

        public IDataResult<Bank> Get(Expression<Func<Bank, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Bank>> GetAll(Expression<Func<Bank, bool>> filter = null)
        {
            return new SuccessDataResult<List<Bank>>(_bankDal.GetAll(), Messages.BankListed);
        }

        public IDataResult<Bank> GetEntityById(int id)
        {
            return new SuccessDataResult<Bank>(_bankDal.Get(b => b.Id == id), Messages.BankListed);
        }

        public IResult Update(Bank entity)
        {
            _bankDal.Update(entity);
            return new SuccessResult(Messages.BankUpdated);
        }
    }



}
