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
    public class CurrentAccountManager : ICurrentAccountService
    {

        ICurrentAccountDal _currentAccountDal;

        public CurrentAccountManager(ICurrentAccountDal currentAccountDal)
        {
            _currentAccountDal = currentAccountDal;
        }

        public IResult Add(CurrentAccount entity)
        {
            _currentAccountDal.Add(entity);
            return new SuccessResult(Messages.CurrentAccountAdded);
        }

        public IResult Delete(CurrentAccount entity)
        {
            _currentAccountDal.Delete(entity);
            return new SuccessResult(Messages.CurrentAccountDeleted);
        }

        public IDataResult<CurrentAccount> Get(Expression<Func<CurrentAccount, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CurrentAccount>> GetAll(Expression<Func<CurrentAccount, bool>> filter = null)
        {
            return new SuccessDataResult<List<CurrentAccount>>(_currentAccountDal.GetAll(), Messages.CurrentAccountListed);
        }

        public IDataResult<CurrentAccount> GetEntityById(int id)
        {
            return new SuccessDataResult<CurrentAccount>(_currentAccountDal.Get(b => b.CurrentAccountId == id), Messages.CurrentAccountListed);
        }

        public IResult Update(CurrentAccount entity)
        {
            _currentAccountDal.Update(entity);
            return new SuccessResult(Messages.CurrentAccountUpdated);
        }
    }

}
