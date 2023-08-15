using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmutMermer.WebUI.Dtos.ProductsDto
{
    public class ProductAddDto
    {
        [Required(ErrorMessage ="Lütfen Ürün İsmi Giriniz.")]
        public string Name { get; set; }
        public string Images { get; set; }


        [Required(ErrorMessage = "Lütfen Ürün Açıklaması Giriniz.")]
        public string Description { get; set; }
    }
}
