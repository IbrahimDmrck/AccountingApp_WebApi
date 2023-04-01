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
    public class AddressBookManager : IAddressBookService
    {
        IAddressBookDal _addressBookDal;

        public AddressBookManager(IAddressBookDal addressBookDal)
        {
            _addressBookDal = addressBookDal;
        }

        public IResult Add(AddressBook entity)
        {
            _addressBookDal.Add(entity);
            return new SuccessResult(Messages.AddressBookAdded);
        }

        public IResult Delete(AddressBook entity)
        {
            _addressBookDal.Delete(entity);
            return new SuccessResult(Messages.AddressBookDeleted);
        }

        public IDataResult<AddressBook> Get(Expression<Func<AddressBook, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<AddressBook>> GetAll(Expression<Func<AddressBook, bool>> filter = null)
        {
            return new SuccessDataResult<List<AddressBook>>(_addressBookDal.GetAll(), Messages.AddressBookListed);
        }

        public IDataResult<AddressBook> GetEntityById(int id)
        {
            return new SuccessDataResult<AddressBook>(_addressBookDal.Get(b => b.Id == id), Messages.AddressBookListed);
        }

        public IResult Update(AddressBook entity)
        {
            _addressBookDal.Update(entity);
            return new SuccessResult(Messages.AddressBookUpdated);
        }
    }

}
