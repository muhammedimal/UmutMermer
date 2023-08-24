using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebUI.Dtos.CategoryDto
{
    public class CategoryGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
