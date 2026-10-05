using CourseApp.Data;
using CourseApp.Exceptions;
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
    
    public async Task CreateEnrollmentAsync(int studentId, int courseId)
    {
        if (_academyDbContext.Enrollments.Any(x => x.StudentId == studentId && x.CourseId == courseId))
        {
            throw new AlreadyEnrolledException("Student is already enrolled in this course.");
        }
        var enrollment = new Enrollment
        {
            StudentId = studentId,
            CourseId = courseId,
            EnrollmentDate = DateTime.Now
        };
        
        await _academyDbContext.Enrollments.AddAsync(enrollment);
        await _academyDbContext.SaveChangesAsync();
    }
    
    public async Task DeleteEnrollmentAsync(int id)
    {
        var enrollment = await _academyDbContext.Enrollments.FindAsync(id);
        if (enrollment == null)
        {
            Console.WriteLine("Enrollment not found.");
            return;
        }
        _academyDbContext.Enrollments.Remove(enrollment);
        await _academyDbContext.SaveChangesAsync();
    }
    
    public async Task GetEnrollmentsByStudentAsync(int studentId)
    {
        var enrollments = await _academyDbContext.Enrollments
            .Include(e => e.Course)
            .Where(e => e.StudentId == studentId)
            .ToListAsync();
        
        foreach (var enrollment in enrollments)
        {
            Console.WriteLine(enrollment);
        }
    }
    
    public async Task GetStudentWithMostEnrollmentsAsync()
    {
        var student = await _academyDbContext.Students
            .Include(s => s.Enrollments)
            .OrderByDescending(s => s.Enrollments.Count)
            .Select(e=> new { e.Name, EnrollmentCount = e.Enrollments.Count })
            .FirstOrDefaultAsync();
        if (student == null)
        {
            Console.WriteLine("No students found.");
            return;
        }
        
        Console.WriteLine(student);
    }
    
    
}