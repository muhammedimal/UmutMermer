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
    public class CompanyInfoManager : ICompanyİnfoService
    {
        private readonly ICompanyInfoDal _companyİnfoDal;

        public CompanyInfoManager(ICompanyInfoDal companyİnfoDal)
        {
            _companyİnfoDal = companyİnfoDal;
        }

        public void TDelete(CompanyInfo t)
        {
            _companyİnfoDal.Delete(t);
        }

        public CompanyInfo TGetById(int id)
        {
            return _companyİnfoDal.GetById(id); 
        }

        public List<CompanyInfo> TGetList()
        {
            return _companyİnfoDal.GetList  (); 
        }

        public void TInsert(CompanyInfo t)
        {
             _companyİnfoDal.Insert   (t);    
        }

        public void TUpdate(CompanyInfo t)
        {
            _companyİnfoDal.Update (t);
        }
    }
}
