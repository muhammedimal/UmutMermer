using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmutMermer.BusinessLayer.Abstract;
using UmutMermer.DataAccesLayer.Abstract;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.BusinessLayer.Concrete
{
    public class ProductsManager : IProductsService
    {
        private readonly IProductsDal _productsDal;

        public ProductsManager(IProductsDal productsDal)
        {
            _productsDal = productsDal;
        }

        public void TDelete(Products t)
        {
            _productsDal.Delete(t);
        }

        public Products TGetById(int id)
        {
            return _productsDal.GetById(id);
        }

        public List<Products> TGetList()
        {
            return _productsDal.GetList();
        }

        public void TInsert(Products t)
        {
            _productsDal.Insert(t);
        }

        public void TUpdate(Products t)
        {
            _productsDal.Update(t);
        }
    }
}
