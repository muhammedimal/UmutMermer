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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void TDelete(Category t)
        {
            _categorydal.Delete(t);
        }

        public Category TGetById(int id)
        {
            return _categorydal.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _categorydal.GetList();
        }

        public void TInsert(Category t)
        {
           _categorydal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categorydal.Update(t);
        }
    }
}
