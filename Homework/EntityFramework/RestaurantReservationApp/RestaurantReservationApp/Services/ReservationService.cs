using RestaurantApp.Data;
using RestaurantApp.Exceptions;
using RestaurantApp.Models;

namespace RestaurantApp.Services;

public class ReservationService
{
    
    private readonly RestaurantDbContext _restaurantDbContext;
    
    public ReservationService()
    {
        _restaurantDbContext = new RestaurantDbContext();
    }

    public async Task CreateReservation(int restaurantId, string customerName, DateTime reservationDate,int guestCount)
    {
        if(reservationDate < DateTime.Now)
        {
            throw new InvalidReservationDateException("Reservation date cannot be in the past.");
        }
        
        var restaurant = await _restaurantDbContext.Restaurants.FindAsync(restaurantId);

        if (restaurant == null)
        {
            Console.WriteLine("Restaurant not found.");
            return;
        }
        
        if (restaurant.Capacity < guestCount)
        {
            throw new RestaurantFullException("The restaurant cannot accommodate the requested number of guests.");
        }
        
        await  _restaurantDbContext.Reservations.AddAsync(new Reservation
        {
            RestaurantId = restaurantId,
            CustomerName = customerName,
            ReservationDate = reservationDate,
            GuestCount = guestCount,
            IsCompleted = false
        });
        await _restaurantDbContext.SaveChangesAsync();
    }
    
    public async Task CompleteReservation(int reservationId)
    {
        var reservation = await _restaurantDbContext.Reservations.FindAsync(reservationId);
        if (reservation == null)
        {
            Console.WriteLine("Reservation not found.");
            return;
        }
        reservation.IsCompleted = true;
        await _restaurantDbContext.SaveChangesAsync();
    }
}