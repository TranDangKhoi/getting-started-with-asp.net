using System.ComponentModel.DataAnnotations;

namespace first_asp.net_core_web_app.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        // Genre can be null
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
