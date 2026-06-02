namespace BookApp.Exceptions;

public class BookOutOfStockException : Exception
{
    public BookOutOfStockException(string message) : base(message)
    {
        
    }
}