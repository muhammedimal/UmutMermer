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
    public class CompanyInfoManager : ICompanyInfoService
    {
        private readonly ICompanyInfoDal _companyInfoDal;

        public CompanyInfoManager(ICompanyInfoDal companyInfoDal)
        {
            _companyInfoDal = companyInfoDal;
        }

        public void TDelete(CompanyInfo t)
        {
            _companyInfoDal.Delete(t);
        }

        public CompanyInfo TGetById(int id)
        {
            return _companyInfoDal.GetById(id); 
        }

        public List<CompanyInfo> TGetList()
        {
            return _companyInfoDal.GetList  (); 
        }

        public void TInsert(CompanyInfo t)
        {
             _companyInfoDal.Insert   (t);    
        }

        public void TUpdate(CompanyInfo t)
        {
            _companyInfoDal.Update (t);
        }
    }
}
