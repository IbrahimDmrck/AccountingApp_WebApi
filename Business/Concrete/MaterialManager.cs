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
    public class MaterialManager : IMaterialService
    {
        IMaterialsDal _materialsDal;

        public MaterialManager(IMaterialsDal materialsDal)
        {
            _materialsDal = materialsDal;
        }

        public IResult Add(Materials entity)
        {
            _materialsDal.Add(entity);
            return new SuccessResult(Messages.MaterialAdded);
        }

        public IResult Delete(Materials entity)
        {
            _materialsDal.Delete(entity);
            return new SuccessResult(Messages.MaterialDeleted);
        }

        public IDataResult<Materials> Get(Expression<Func<Materials, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Materials>> GetAll(Expression<Func<Materials, bool>> filter = null)
        {
            return new SuccessDataResult<List<Materials>>(_materialsDal.GetAll(), Messages.MaterialListed);
        }

        public IDataResult<Materials> GetEntityById(int id)
        {
            return new SuccessDataResult<Materials>(_materialsDal.Get(b => b.Id == id), Messages.MaterialListed);
        }

        public IResult Update(Materials entity)
        {
            _materialsDal.Update(entity);
            return new SuccessResult(Messages.MaterialUpdated);
        }
    }

}
