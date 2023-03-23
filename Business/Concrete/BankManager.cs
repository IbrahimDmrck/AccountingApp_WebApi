using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
        public IResult Add(Bank entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Bank entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Bank> Get(Expression<Func<Bank, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Bank>> GetAll(Expression<Func<Bank, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Bank entity)
        {
            throw new NotImplementedException();
        }
    }



}
