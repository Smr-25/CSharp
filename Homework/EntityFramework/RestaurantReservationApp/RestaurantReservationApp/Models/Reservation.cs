namespace RestaurantApp.Models;

public class Reservation
{
    public int Id { get; set; }
    
    public int RestaurantId { get; set; }

    public string CustomerName { get; set; }
    
    public DateTime ReservationDate { get; set; }
    
    public int GuestCount { get; set; }
    
    public Restaurant Restaurant { get; set; }

    public bool IsCompleted { get; set; }

    public override string ToString()
    {
        return $"Reservation Id: {Id}, RestaurantId: {RestaurantId}, CustomerName: {CustomerName}, ReservationDate: {ReservationDate}, GuestCount: {GuestCount}, IsCompleted: {IsCompleted}";
    }
}
