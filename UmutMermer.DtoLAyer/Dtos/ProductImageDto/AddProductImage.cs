using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmutMermer.DtoLAyer.Dtos.ProductImageDto
{
    public class AddProductImage 
    {
        public int ProductId { get; set; }
        public IFormFile UploadFile { get; set; }

    }
}
