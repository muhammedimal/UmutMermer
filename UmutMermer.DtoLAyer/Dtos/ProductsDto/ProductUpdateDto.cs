using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.DtoLAyer.Dtos.ProductsDto
{
    public class ProductUpdateDto
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Lütfen Ürün İsmi Giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Ürün Açıklaması Giriniz.")]
        public string Description { get; set; }
        public int CategoryId { get; set; }
 
    }
}
