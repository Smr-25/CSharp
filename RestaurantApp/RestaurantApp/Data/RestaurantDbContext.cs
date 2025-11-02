using Microsoft.EntityFrameworkCore;
using RestaurantApp.Models;

namespace RestaurantApp.Data;

public class RestaurantDbContext : DbContext
{
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
    }
}