using Microsoft.EntityFrameworkCore;
using StudentDepartmentAPI.Models;
using System;

namespace StudentDepartmentAPI
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
