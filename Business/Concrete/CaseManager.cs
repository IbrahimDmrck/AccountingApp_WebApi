using Business.Abstract;
using Business.Constants;
using Core.CrossCuttingconcerns.Caching;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CaseManager : ICaseService
    {
        ICaseDal _caseDal;

        public CaseManager(ICaseDal caseDal)
        {
            _caseDal = caseDal;
        }

        public IResult Add(Case entity)
        {
            _caseDal.Add(entity);
            return new SuccessResult(Messages.CaseAdded);
        }

        public IResult Delete(Case entity)
        {
            _caseDal.Delete(entity);
            return new SuccessResult(Messages.CaseDeleted);
        }

        public IDataResult<Case> Get(Expression<Func<Case, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Case>> GetAll(Expression<Func<Case, bool>> filter = null)
        {
            return new SuccessDataResult<List<Case>>(_caseDal.GetAll(), Messages.CaseListed);
        }

        public IDataResult<Case> GetEntityById(int id)
        {
            return new SuccessDataResult<Case>(_caseDal.Get(b => b.ID == id), Messages.CaseListed);
        }

        public IResult Update(Case entity)
        {
            _caseDal.Update(entity);
            return new SuccessResult(Messages.CaseUpdated);
        }
    }

}
