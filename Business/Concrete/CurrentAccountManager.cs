using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(CurrentAccount entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CurrentAccount> Get(Expression<Func<CurrentAccount, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CurrentAccount>> GetAll(Expression<Func<CurrentAccount, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CurrentAccount entity)
        {
            throw new NotImplementedException();
        }
    }

}
