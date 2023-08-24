using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmutMermer.EntityLayer.Concrate
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Path { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }

 
    }
}
