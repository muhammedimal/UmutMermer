using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmutMermer.EntityLayer.Concrate
{
    public class Product
    {
        public int  ProductId { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public string Description { get; set; }
       
        public ICollection<ProductImage>? ProductImage { get; set; }  
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
