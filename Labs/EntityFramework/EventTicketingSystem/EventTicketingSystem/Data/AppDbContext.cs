using Microsoft.EntityFrameworkCore;
using Pa201LabN7.Models;

namespace Pa201LabN7.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Event> Events { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MOON01\\SQLEXPRESS;Database=TicketSystemDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

    }
}
