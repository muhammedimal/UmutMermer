using UmutMermer.EntityLayer.Concrate;

namespace UmutMermer.WebUI.Models.CategoryDto
{
    public class GetCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

    }

}
