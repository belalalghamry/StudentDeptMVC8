using System.ComponentModel.DataAnnotations;
using StudentDeptMVC8.Models;


namespace StudentDeptMVC8.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }              // Primary Key

        [Required(ErrorMessage = "Student name is required")]
        [StringLength(100)]
        public string Name { get; set; } = "";   // Student Name

        [Range(16, 100, ErrorMessage = "Age must be between 16 and 100")]
        public int Age { get; set; }             // Student Age

        // Foreign Key
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        // Navigation Property
        public Department? Department { get; set; }
    }
}
