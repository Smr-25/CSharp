namespace RestaurantApp.Exceptions;

public class RestaurantFullException : Exception
{
    public RestaurantFullException(string message) : base(message)
    {
        
    }    
}