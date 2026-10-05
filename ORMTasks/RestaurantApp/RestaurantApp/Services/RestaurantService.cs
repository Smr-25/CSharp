using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data;
using RestaurantApp.Models;

namespace RestaurantApp.Services;

public class RestaurantService
{
    private readonly RestaurantDbContext _restaurantDbContext;

    public RestaurantService()
    {
        _restaurantDbContext = new RestaurantDbContext();
        
    }

    public async Task CreateRestaurant(string name, int capacity, decimal raiting)
    {
        var restaurant = new Restaurant
        {
            Name = name,
            Capacity = capacity,
            Raiting = raiting
        };

        await _restaurantDbContext.Restaurants.AddAsync(restaurant);
        await _restaurantDbContext.SaveChangesAsync();
    }

    public async Task UpdateRestaurant(int id, string name, int capacity, decimal raiting)
    {
        var restaurant = await _restaurantDbContext.Restaurants.FindAsync(id);
        if (restaurant == null)
        {
            Console.WriteLine("Restaurant not found.");
            return;
        }
        restaurant.Name = name;
        restaurant.Capacity = capacity;
        restaurant.Raiting = raiting;
        await _restaurantDbContext.SaveChangesAsync();
    }
    
    public async Task DeleteRestaurant(int id)
    {
        var restaurant = await _restaurantDbContext.Restaurants.FindAsync(id);
        if (restaurant == null)
        {
            Console.WriteLine("Restaurant not found.");
            return;
        }
        _restaurantDbContext.Restaurants.Remove(restaurant);
        await _restaurantDbContext.SaveChangesAsync();
    }
    
    public async Task GetAllRestaurants()
    {
        var restaurants = await _restaurantDbContext.Restaurants.ToListAsync();
        foreach (var restaurant in restaurants)
        {
            Console.WriteLine(restaurant);
        }
    }

    public async Task GetRestaurantWithReservations(int id)
    {
        var restaurants = await _restaurantDbContext.Restaurants
            .Include(r => r.Reservations)
            .OrderByDescending(r => r.Reservations.Count)
            .Select(r => new { Name = r.Name, ResarvationsCount = r.Reservations.Count }).ToListAsync();

        foreach (var restaurant in restaurants)
        {
            Console.WriteLine(restaurant);
        }
    }
    
    public async Task GetTopThreeRestaurantsByRaiting()
    {
        var restaurants = await _restaurantDbContext.Restaurants
            .OrderByDescending(r => r.Raiting)
            .Take(3)
            .ToListAsync();

        foreach (var restaurant in restaurants)
        {
            Console.WriteLine(restaurant);
        }
    }

    public async Task GetRestaurantsWithGuestCount()
    {
        var restaurants = await _restaurantDbContext.Restaurants
            .Include(r => r.Reservations)
            .Select(r => new
            {
                Name = r.Name,
                TotalGuests = r.Reservations.Where(r => r.IsCompleted).Sum(r => r.GuestCount)
            })
            .ToListAsync();

        foreach (var restaurant in restaurants)
        {
            Console.WriteLine(restaurant);
        }
    }
}