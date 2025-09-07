using Microsoft.EntityFrameworkCore;

namespace StudentDeptMVC8.Models   // ✅ مهم جداً يكون نفس الاسم ده
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
