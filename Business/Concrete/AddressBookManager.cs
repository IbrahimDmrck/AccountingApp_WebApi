using Business.Abstract;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class AddressBookManager : IAddressBookService
    {
        public IResult Add(AddressBook entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(AddressBook entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AddressBook> Get(Expression<Func<AddressBook, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<AddressBook>> GetAll(Expression<Func<AddressBook, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(AddressBook entity)
        {
            throw new NotImplementedException();
        }
    }

}
