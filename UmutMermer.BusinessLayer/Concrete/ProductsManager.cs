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

        public void TDelete(Product t)
        {
            _productsDal.Delete(t);
        }

        public Product TGetById(int id)
        {
            return _productsDal.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _productsDal.GetList();
        }

        public void TInsert(Product t)
        {
            _productsDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productsDal.Update(t);
        }
    }
}
