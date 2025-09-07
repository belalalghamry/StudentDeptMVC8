using Microsoft.EntityFrameworkCore;
using StudentDeptMVC8.Models;
using System.Linq;

namespace StudentDeptMVC8.Data
{
    public static class AppDbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // لو جدول الأقسام فاضي
            if (!context.Departments.Any())
            {
                context.Departments.AddRange(
                    new Department { DeptName = "Computer Science" },
                    new Department { DeptName = "Mathematics" },
                    new Department { DeptName = "Physics" }
                );

                context.SaveChanges();
            }
        }
    }
}
