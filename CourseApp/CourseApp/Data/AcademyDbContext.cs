using CourseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Data;

public class AcademyDbContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Course> Courses { get; set; }
    
    public DbSet<Enrollment> Enrollments { get; set; }
    
    public DbSet<Student> Students { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
    }
}