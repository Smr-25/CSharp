namespace CourseApp.Exceptions;

public class InvalidCourseCreditException : Exception
{
    public InvalidCourseCreditException(string message) : base(message)
    {
        
    }
}