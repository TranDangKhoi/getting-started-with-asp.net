using Microsoft.Extensions.Hosting;

namespace ClothingStoreAPI.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Clothes> Clothes { get; set; }

    }
}
