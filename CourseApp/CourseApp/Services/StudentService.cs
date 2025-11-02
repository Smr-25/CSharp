using CourseApp.Data;
using CourseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Services;

public class StudentService
{
    private readonly AcademyDbContext _academyDbContext;

    public StudentService()
    {
        _academyDbContext = new AcademyDbContext();
    }
    
    public async Task CreateStudentAsync(string name, string email)
    {
        var student = new Student
        {
            Name = name,
            Email = email
        };
        
        await _academyDbContext.Students.AddAsync(student);
        await _academyDbContext.SaveChangesAsync();
    }
    
    public async Task UpdateStudentAsync(int id, string name, string email)
    {
        var student = await _academyDbContext.Students.FindAsync(id);
        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }
        student.Name = name;
        student.Email = email;  
        await _academyDbContext.SaveChangesAsync();
    }
    
    public async Task DeleteStudentAsync(int id)
    {
        var student = await _academyDbContext.Students.FindAsync(id);
        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }
        _academyDbContext.Students.Remove(student);
        await _academyDbContext.SaveChangesAsync();
    }
    
    public async Task GetAllStudentsAsync()
    {
       var students = await _academyDbContext.Students.ToListAsync();
         foreach (var student in students)
         {
              Console.WriteLine(student);
         }
    }
}