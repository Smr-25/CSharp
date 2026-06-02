using CourseApp.Data;

namespace CourseApp.Models;

public class Teacher
{
    public int Id { get; set; }
    
    public string FullName { get; set;  }

    public string Specialty { get; set; }
    
    public List<Course> Courses { get; set; }

    public override string ToString()
    {
        return $"Teacher Id: {Id}, Name: {FullName}, Specialty: {Specialty}";
    }
}