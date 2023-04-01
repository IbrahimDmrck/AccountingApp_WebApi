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
    public class MaterialSalesManager : IMaterialSalesService
    {
        IMaterialSalesDal _materialSalesDal;

        public MaterialSalesManager(IMaterialSalesDal materialSalesDal)
        {
            _materialSalesDal = materialSalesDal;
        }

        public IResult Add(MaterialSales entity)
        {
            _materialSalesDal.Add(entity);
            return new SuccessResult(Messages.MaterialSalesAdded);
        }

        public IResult Delete(MaterialSales entity)
        {
            _materialSalesDal.Delete(entity);
            return new SuccessResult(Messages.MaterialSalesDeleted);
        }

        public IDataResult<MaterialSales> Get(Expression<Func<MaterialSales, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MaterialSales>> GetAll(Expression<Func<MaterialSales, bool>> filter = null)
        {
            return new SuccessDataResult<List<MaterialSales>>(_materialSalesDal.GetAll(), Messages.MaterialSalesListed);
        }

        public IDataResult<MaterialSales> GetEntityById(int id)
        {
            return new SuccessDataResult<MaterialSales>(_materialSalesDal.Get(b => b.Id == id), Messages.MaterialSalesListed);
        }

        public IResult Update(MaterialSales entity)
        {
            _materialSalesDal.Update(entity);
            return new SuccessResult(Messages.MaterialSalesUpdated);
        }
    }

}
