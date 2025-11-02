using BookApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Data;

public class LibraryDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    
    public DbSet<Borrow> Borrows { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
    }
}

