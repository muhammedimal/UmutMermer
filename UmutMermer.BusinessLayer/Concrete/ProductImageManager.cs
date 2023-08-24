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
    public class ProductImageManager : IProductImageService
    {
        private readonly IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public void TDelete(ProductImage t)
        {
            _productImageDal.Delete(t);
        }

        public ProductImage TGetById(int id)
        {
            return _productImageDal.GetById(id);
        }

        public List<ProductImage> TGetList()
        {
          return _productImageDal.GetList();
        }

        public void TInsert(ProductImage t)
        {
            _productImageDal.Insert(t);
        }

        public void TUpdate(ProductImage t)
        {
            _productImageDal.Update(t);
        }
    }
}
