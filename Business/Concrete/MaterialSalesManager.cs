using Business.Abstract;
using Core.Utilities.Result.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(MaterialSales entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<MaterialSales> Get(Expression<Func<MaterialSales, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MaterialSales>> GetAll(Expression<Func<MaterialSales, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MaterialSales entity)
        {
            throw new NotImplementedException();
        }
    }

}
