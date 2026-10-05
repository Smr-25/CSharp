namespace CourseApp.Models;

public class Course
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public int Credit { get; set; }

    public int TeacherId { get; set; }
    
    public Teacher Teacher { get; set; }
    
    public List<Enrollment> Enrollments { get; set; }
}