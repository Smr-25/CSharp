namespace RestaurantApp.Exceptions;

public class InvalidReservationDateException : Exception
{
    public InvalidReservationDateException(string message) : base(message)
    {
        
    }
}