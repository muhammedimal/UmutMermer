using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmutMermer.DataAccesLayer.Abstract;
using UmutMermer.DataAccesLayer.Concrete;
using UmutMermer.DataAccesLayer.Repositories;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.DataAccesLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }
    }
}
