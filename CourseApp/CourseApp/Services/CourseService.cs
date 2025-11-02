using CourseApp.Data;
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
}