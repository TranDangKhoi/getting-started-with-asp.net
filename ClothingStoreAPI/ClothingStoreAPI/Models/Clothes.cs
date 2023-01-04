namespace ClothingStoreAPI.Models
{
    public class Clothes
    {
        public int Id { get; set; }
        public string? Thumbnail { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public int Remains { get; set; }
        public bool Status { get; set; }

        public int CategoryId { get; set; }

        public Categories Category { get; set; }

    }
}
