using System.ComponentModel.DataAnnotations;

namespace PracticalExam.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Department { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
