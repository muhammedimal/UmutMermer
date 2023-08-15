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
    public class CompanyİnfoManager : ICompanyİnfoService
    {
        private readonly ICompanyİnfoDal _companyİnfoDal;

        public CompanyİnfoManager(ICompanyİnfoDal companyİnfoDal)
        {
            _companyİnfoDal = companyİnfoDal;
        }

        public void TDelete(Companyİnfo t)
        {
            _companyİnfoDal.Delete(t);
        }

        public Companyİnfo TGetById(int id)
        {
            return _companyİnfoDal.GetById(id); 
        }

        public List<Companyİnfo> TGetList()
        {
            return _companyİnfoDal.GetList  (); 
        }

        public void TInsert(Companyİnfo t)
        {
             _companyİnfoDal.Insert   (t);    
        }

        public void TUpdate(Companyİnfo t)
        {
            _companyİnfoDal.Update (t);
        }
    }
}
