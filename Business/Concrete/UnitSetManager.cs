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
    public class UnitSetManager : IUnitSetService
    {
        IUnitSetDal _unitSetDal;

        public UnitSetManager(IUnitSetDal unitSetDal)
        {
            _unitSetDal = unitSetDal;
        }

        public IResult Add(UnitSet entity)
        {
            _unitSetDal.Add(entity);
            return new SuccessResult(Messages.UnitSetAdded);
        }

        public IResult Delete(UnitSet entity)
        {
            _unitSetDal.Delete(entity);
            return new SuccessResult(Messages.UnitSetDeleted);
        }

        public IDataResult<UnitSet> Get(Expression<Func<UnitSet, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UnitSet>> GetAll(Expression<Func<UnitSet, bool>> filter = null)
        {
            return new SuccessDataResult<List<UnitSet>>(_unitSetDal.GetAll(), Messages.UnitSetListed);
        }

        public IDataResult<UnitSet> GetEntityById(int id)
        {
            return new SuccessDataResult<UnitSet>(_unitSetDal.Get(b => b.Id == id), Messages.UnitSetListed);
        }

        public IResult Update(UnitSet entity)
        {
            _unitSetDal.Update(entity);
            return new SuccessResult(Messages.UnitSetUpdated);
        }
    }

}
