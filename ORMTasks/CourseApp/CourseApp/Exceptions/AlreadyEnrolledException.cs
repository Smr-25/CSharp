namespace CourseApp.Exceptions;

public class AlreadyEnrolledException : Exception
{
    public AlreadyEnrolledException(string message) : base(message)
    {
        
    }
}