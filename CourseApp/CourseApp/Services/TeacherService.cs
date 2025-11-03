using CourseApp.Data;
using CourseApp.Exceptions;
using CourseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Services;

public class TeacherService
{
    private readonly AcademyDbContext _academyDbContext;
    
    public TeacherService()
    {
        _academyDbContext = new AcademyDbContext();
    }
    
    public async Task CreateTeacherAsync(string fullname, string specialty)
    {
        if (specialty == null)
        {
            throw new InvalidSpecialtyException("Specialty cannot be null.");
        }
        var teacher = new Teacher
        {
            FullName = fullname,
            Specialty = specialty
        };
        
        await _academyDbContext.Teachers.AddAsync(teacher);
        await  _academyDbContext.SaveChangesAsync();
    }

    public async Task UpdateTeacherAsync(int id, string fullname, string specialty)
    {
        var teacher = await _academyDbContext.Teachers.FindAsync(id);
        if (teacher == null)
        {
            Console.WriteLine("Teacher not found.");
            return;
        }
        teacher.FullName = fullname;
        teacher.Specialty = specialty;  
        await _academyDbContext.SaveChangesAsync();
    }

    public async Task DeleteTeacherAsync(int id)
    {
        var teacher = await _academyDbContext.Teachers.FindAsync(id);
        if (teacher == null)
        {
            Console.WriteLine("Teacher not found.");
            return;
        }
        _academyDbContext.Teachers.Remove(teacher);
        await _academyDbContext.SaveChangesAsync();
    }
    
    public async Task GetAllTeachersAsync()
    {
       var teachers = await _academyDbContext.Teachers.ToListAsync();
         foreach (var teacher in teachers)
         {
              Console.WriteLine(teacher);
         }
    }
    
    public async Task GetTeacherWithMostCoursesAsync()
    {
        var teacher = await _academyDbContext.Teachers
            .Include(t => t.Courses)
            .OrderByDescending(t => t.Courses.Count).Select(t=> new{FullName = t.FullName, CourseCount = t.Courses.Count})
            .FirstOrDefaultAsync();
        
        if (teacher == null)
        {
            Console.WriteLine("No teachers found.");
            return;
        }
        
        Console.WriteLine(teacher);
    }

    public async Task GetTeachersWithCourseCountAsync()
    {
        var teachers = await _academyDbContext.Teachers
            .Include(t => t.Courses)
            .Select(t => new { FullName = t.FullName, CourseCount = t.Courses.Count })
            .ToListAsync();

        foreach (var teacher in teachers)
        {
            Console.WriteLine(teacher);
        }
    }

    public async Task GetTeachersWithStudentCountAsync()
    {
        var teachers = await _academyDbContext.Teachers
            .Include(t => t.Courses)
            .ThenInclude(c => c.Enrollments)
            .ThenInclude(e => e.Student)
            .Select(t => new 
            { 
                FullName = t.FullName, 
                StudentCount = t.Courses
                    .SelectMany(c => c.Enrollments)
                    .Select(e => e.StudentId)
                    .Distinct()
                    .Count() 
            })
            .ToListAsync();

        foreach (var teacher in teachers)
        {
            Console.WriteLine(teacher);
        }
    }
}