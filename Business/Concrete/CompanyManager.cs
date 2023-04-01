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
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company entity)
        {
            _companyDal.Add(entity);
            return new SuccessResult(Messages.CompanyAdded);
        }

        public IResult Delete(Company entity)
        {
            _companyDal.Delete(entity);
            return new SuccessResult(Messages.CompanyDeleted);
        }

        public IDataResult<Company> Get(Expression<Func<Company, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Company>> GetAll(Expression<Func<Company, bool>> filter = null)
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(), Messages.CompanyListed);
        }

        public IDataResult<Company> GetEntityById(int id)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(b => b.Id == id), Messages.CompanyListed);
        }

        public IResult Update(Company entity)
        {
            _companyDal.Update(entity);
            return new SuccessResult(Messages.CompanyUpdated);
        }
    }

}
