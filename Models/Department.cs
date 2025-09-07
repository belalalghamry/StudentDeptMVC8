using System.ComponentModel.DataAnnotations;
using StudentDeptMVC8.Models;


namespace StudentDeptMVC8.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }                 // Primary Key

        [Required(ErrorMessage = "Department name is required")]
        [StringLength(100)]
        [Display(Name = "Department Name")]
        public string DeptName { get; set; } = "";  // Department Name

        // Navigation Property (One-to-Many)
        public List<Student> Students { get; set; } = new();
    }
}
