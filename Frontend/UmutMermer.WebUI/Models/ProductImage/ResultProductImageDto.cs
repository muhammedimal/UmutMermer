using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebUI.Models.ProductImage
{
    public class ResultProductImageDto
    {
        public int Id { get; set; }
        public string? Path { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
    }
}
