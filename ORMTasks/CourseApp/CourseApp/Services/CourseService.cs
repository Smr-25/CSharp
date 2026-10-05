using CourseApp.Data;
using CourseApp.Exceptions;
using CourseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Services;

public class CourseService
{
    private readonly AcademyDbContext _academyDbContextdbContext;
    
    public CourseService()
    {
        _academyDbContextdbContext = new AcademyDbContext();
    }
    
    public async Task CreateCourseAsync(string name, int credit, int teacherId)
    {
        if (credit <= 0)
        {
            throw new InvalidCourseCreditException("Course credit must be a positive integer.");
        }
        var course = new Course
        {
            Name = name,
            Credit = credit,
            TeacherId = teacherId
        };
        
        await _academyDbContextdbContext.Courses.AddAsync(course);
        await _academyDbContextdbContext.SaveChangesAsync();
    }
    
    public async Task UpdateCourseAsync(int id, string name, int credit, int teacherId)
    {
        var course = await _academyDbContextdbContext.Courses.FindAsync(id);
        if (course == null)
        {
            Console.WriteLine("Course not found.");
            return;
        }
        course.Name = name;
        course.Credit = credit;
        course.TeacherId = teacherId;  
        await _academyDbContextdbContext.SaveChangesAsync();
    }
    
    public async Task DeleteCourseAsync(int id)
    {
        var course = await _academyDbContextdbContext.Courses.FindAsync(id);
        if (course == null)
        {
            Console.WriteLine("Course not found.");
            return;
        }
        _academyDbContextdbContext.Courses.Remove(course);
        await _academyDbContextdbContext.SaveChangesAsync();
    }
    
    public async Task GetAllCoursesAsync()
    {
       var courses = await _academyDbContextdbContext.Courses.ToListAsync();
         foreach (var course in courses)
         {
              Console.WriteLine($"Course Id: {course.Id}, Name: {course.Name}, Credit: {course.Credit}, TeacherId: {course.TeacherId}");
         }
    }

    public async Task GetCoursesByTeacher(int teacherId)
    {
        var courses = await _academyDbContextdbContext.Courses.Where(x => x.TeacherId == teacherId).ToListAsync();
        foreach (var course in courses)
        {
            Console.WriteLine(course);
        }
    }
    
    public async Task GetCourseWithMostStudentsAsync()
    {
        var course = await _academyDbContextdbContext.Courses
            .Include(c => c.Enrollments)
            .OrderByDescending(c => c.Enrollments.Count)
            .FirstOrDefaultAsync();

        if (course == null)
        {
            Console.WriteLine("No courses found.");
            return;
        }
        Console.WriteLine(course);
    }
    
    public async Task GetCoursesWithStudentsAsync(int courseId)
    {
        var course = await _academyDbContextdbContext.Courses
            .Include(c => c.Enrollments)
            .ThenInclude(e => e.Student)
            .FirstOrDefaultAsync(c => c.Id == courseId);

        if (course == null)
        {
            Console.WriteLine("Course not found.");
            return;
        }

        foreach (var enrollment in course.Enrollments)
        {
            Console.WriteLine($"Student: {enrollment.Student.Name}");
        }
    }
}