﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmutMermer.DtoLAyer.Dtos.ProductsDto
{
    public class ProductGetDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen Ürün İsmi Giriniz.")]
        public string Name { get; set; }
        public string Images { get; set; }
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Lütfen Ürün Açıklaması Giriniz.")]
        public string Description { get; set; }
    }
}
