namespace RestaurantApp.Models;

public class Restaurant
{
    public int  Id { get; set; }
    
    public string Name { get; set; }
    
    public int Capacity { get; set; } 
    
    public decimal Raiting  { get; set; }
    
    public List<Reservation> Reservations { get; set; }
    
    public override string ToString()
    {
        return $"Restaurant Id: {Id}, Name: {Name}, Capacity: {Capacity}, Raiting: {Raiting}";
    }
}