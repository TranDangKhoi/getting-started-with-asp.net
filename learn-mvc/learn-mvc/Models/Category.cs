using System.ComponentModel.DataAnnotations;

namespace learn_mvc.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public String Name { get; set; }
    public int DisplayOrder { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}
