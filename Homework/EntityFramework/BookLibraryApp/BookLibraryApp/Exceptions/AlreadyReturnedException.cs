namespace BookApp.Exceptions;

public class AlreadyReturnedException : Exception
{
    public AlreadyReturnedException(string message) : base(message)
    {
        
    }
}