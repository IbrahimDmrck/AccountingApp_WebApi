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
    public class SpecialPlugManager : ISpecialPlugService
    {
        ISpecialPlugDal _specialPlugDal;

        public SpecialPlugManager(ISpecialPlugDal specialPlugDal)
        {
            _specialPlugDal = specialPlugDal;
        }

        public IResult Add(SpecialPlug entity)
        {
            _specialPlugDal.Add(entity);
            return new SuccessResult(Messages.SpecialPlugAdded);
        }

        public IResult Delete(SpecialPlug entity)
        {
            _specialPlugDal.Delete(entity);
            return new SuccessResult(Messages.SpecialPlugDeleted);
        }

        public IDataResult<SpecialPlug> Get(Expression<Func<SpecialPlug, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SpecialPlug>> GetAll(Expression<Func<SpecialPlug, bool>> filter = null)
        {
            return new SuccessDataResult<List<SpecialPlug>>(_specialPlugDal.GetAll(), Messages.SpecialPlugListed);
        }

        public IDataResult<SpecialPlug> GetEntityById(int id)
        {
            return new SuccessDataResult<SpecialPlug>(_specialPlugDal.Get(b => b.Id == id), Messages.SpecialPlugListed);
        }

        public IResult Update(SpecialPlug entity)
        {
            _specialPlugDal.Update(entity);
            return new SuccessResult(Messages.SpecialPlugUpdated);
        }
    }

}
