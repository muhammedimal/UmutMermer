using UmutMermer.EntityLayer.Concrate;
using UmutMermer.WebUI.Models.ProductImage;

namespace UmutMermer.WebUI.Models.ProductVM
{
    public class ResultProductVM
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public string Description { get; set; }

        public ICollection<ResultProductImageDto> ProductImage { get; set; }
        public int CategoryId { get; set; }
    }
}
