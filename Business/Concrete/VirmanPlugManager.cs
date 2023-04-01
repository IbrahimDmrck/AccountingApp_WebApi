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
    public class VirmanPlugManager : IVirmanPlugService
    {
        IVirmanPlugDal _virmanPlugDal;

        public VirmanPlugManager(IVirmanPlugDal virmanPlugDal)
        {
            _virmanPlugDal = virmanPlugDal;
        }

        public IResult Add(VirmanPlug entity)
        {
            _virmanPlugDal.Add(entity);
            return new SuccessResult(Messages.VirmanPlugAdded);
        }

        public IResult Delete(VirmanPlug entity)
        {
            _virmanPlugDal.Delete(entity);
            return new SuccessResult(Messages.VirmanPlugDeleted);
        }

        public IDataResult<VirmanPlug> Get(Expression<Func<VirmanPlug, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<VirmanPlug>> GetAll(Expression<Func<VirmanPlug, bool>> filter = null)
        {
            return new SuccessDataResult<List<VirmanPlug>>(_virmanPlugDal.GetAll(), Messages.MaterialVirmanPlugListed);
        }

        public IDataResult<VirmanPlug> GetEntityById(int id)
        {
            return new SuccessDataResult<VirmanPlug>(_virmanPlugDal.Get(b => b.Id == id), Messages.MaterialVirmanPlugListed);
        }

        public IResult Update(VirmanPlug entity)
        {
            _virmanPlugDal.Update(entity);
            return new SuccessResult(Messages.VirmanPlugUpdated);
        }
    }

}
