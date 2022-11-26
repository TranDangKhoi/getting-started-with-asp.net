using System.ComponentModel.DataAnnotations;

namespace learn_mvc.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public String Name { get; set; }
    public int DisplayOrder { get; set; }

    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}
