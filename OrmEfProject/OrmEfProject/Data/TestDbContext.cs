using Microsoft.EntityFrameworkCore;
using OrmEfProject.Models;

namespace OrmEfProject.Data;

public class TestDbContext : DbContext
{
    
    public DbSet<Group> Groups { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.;database=TestDb;TrustServerCertificate=True");
    }
}