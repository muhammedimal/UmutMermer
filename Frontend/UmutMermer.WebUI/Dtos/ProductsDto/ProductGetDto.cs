using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebUI.Dtos.ProductsDto
{
    public class ProductGetDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public string Description { get; set; }

        //public ICollection<ProductImage> ProductImage { get; set; }
        public int CategoryId { get; set; }
    }
}
