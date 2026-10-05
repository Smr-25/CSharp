using Pa201LabN7.Data;
using Pa201LabN7.Exceptions;
using Pa201LabN7.Interfaces;
using Pa201LabN7.Models;

namespace Pa201LabN7.Services
{
    public class TicketService : ITicketService
    {
        private readonly AppDbContext _db;

        private readonly EventService _eventService;

        public TicketService()
        {
            _db = new AppDbContext();
            _eventService = new EventService();
        }

        public async Task GetTicketAsync(int eventId)
        {
            var @event = await _db.Events.FindAsync(eventId);
            if (@event == null)
            {
                return;
            }
            if (@event.Date < DateTime.Now)
            {
                throw new EventExpiredException("Ticket time is not");
            }
            _db.Tickets.Add(new Ticket
            {
                Price = @event.Price,
                EventId = eventId,
                IsUsed = false
            });
            await _db.SaveChangesAsync();
        }


        public async Task UsingTicketAsync(int ticketId)
        {
            var ticket = await _db.Tickets.FindAsync(ticketId);
            if (ticket.IsUsed)
            {
                throw new TicketAlreadyUsedException("Ticket is used");
            }

            ticket.IsUsed = true;
            await _db.SaveChangesAsync();

        }

        public async Task ExecuteGetTicketAsync()
        {
            await _eventService.ListEventWillBeFutureAsync();
            Console.Write("Enter event ID: ");
            var input = Console.ReadLine()?.Trim();

            if (!int.TryParse(input, out var eventId))
            {
                Console.WriteLine("Invalid ID. Please enter a numeric value.");
                return;
            }

            var ev = await _db.Events.FindAsync(eventId);
            if (ev == null)
            {
                Console.WriteLine($"Event with ID {eventId} not found.");
                return;
            }

            await GetTicketAsync(eventId);

        }
    }
}
