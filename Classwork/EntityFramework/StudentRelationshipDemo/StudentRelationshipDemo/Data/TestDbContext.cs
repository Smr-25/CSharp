using Microsoft.EntityFrameworkCore;
using ConsoleApp13.Models;

namespace ConsoleApp13.Data;

public class TestDbContext : DbContext
{

    public DbSet<Group> Groups { get; set; }

    public DbSet<Student> Students { get; set; }

    public DbSet<Subject> Subjects { get; set; }

    public DbSet<StudentSubject> StudentSubjects { get; set; }

    public DbSet<StudentDetail> StudentDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=MOON01\\SQLEXPRESS;Database=TicketSystemDb;Trusted_Connection=True;TrustServerCertificate=True");

    }
}