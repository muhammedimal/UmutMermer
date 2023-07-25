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
    public class PortfolioManager : IPortfolioService
    {
        private readonly IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolio)
        {
            _portfolioDal = portfolio;
        }

        public void TDelete(Portfolio t)
        {
            _portfolioDal.Delete(t);
        }

        public Portfolio TGetById(int id)
        {
            return _portfolioDal.GetById(id);  
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TInsert(Portfolio t)
        {
            _portfolioDal.Update(t);
        }

        public void TUpdate(Portfolio t)
        {
            _portfolioDal.Update(t);
        }
    }
}
