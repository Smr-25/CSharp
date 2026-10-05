namespace CourseApp.Models;

public class Student
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public List<Enrollment> Enrollments { get; set; }

    public override string ToString()
    {
        return $"Student Id: {Id}, Name: {Name}, Email: {Email}";
    }
    
}