using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pa201LabN7.Data;
using Pa201LabN7.Interfaces;
using Pa201LabN7.Models;

namespace Pa201LabN7.Services
{
    public class EventService : IEventService
    {
        private readonly AppDbContext _db;

        public EventService()
        {
            _db = new AppDbContext();
        }

        public async Task CreateEventAsync(string name, DateTime date, decimal price)
        {

            _db.Events.Add(new Event
            {
                Name = name,
                Date = date,
                Price = price
            });
            await _db.SaveChangesAsync();
        }

        public async Task GetAllEventsAsync()
        {
            var events = await _db.Events.ToListAsync();

            foreach (var item in events)
            {
                Console.WriteLine(item);
            }

        }


        public async Task UpdateEventAsync(int id, string name, DateTime date, decimal price)
        {

            var existing = await _db.Events.FindAsync(id);
            if (existing == null)
            {
                return;
            }

            existing.Name = name;
            existing.Date = date;
            existing.Price = price;

            await _db.SaveChangesAsync();
        }




        public async Task DeleteEventAsync(int id)
        {
            var existing = await _db.Events.FindAsync(id);
            if (existing == null)
                return;

            _db.Events.Remove(existing);
            await _db.SaveChangesAsync();
        }


        public async Task ListEventsOrderbyTicketCountDescAsync()
        {
            var events = await _db.Events.Include(e => e.Tickets).OrderByDescending(e => e.Tickets.Count).Select(e => new { Name = e.Name, TicketCount = e.Tickets.Count }).ToListAsync();
            foreach (var item in events)
            {
                Console.WriteLine(item);
            }
        }

        public async Task ListEventsOrderByIncomeDescAsync()
        {
            var events = await _db.Events.Include(e => e.Tickets).OrderByDescending(e => e.Tickets.Sum(e => e.Price)).Select(e => new { Name = e.Name, TicketIncome = e.Tickets.Sum(e => e.Price) }).ToListAsync();
            foreach (var item in events)
            {
                Console.WriteLine(item);
            }
        }

        public async Task ListEventWillBeFutureAsync()
        {
            var events = await _db.Events.Where(e => e.Date > DateTime.Now).ToListAsync();
            foreach (var item in events)
            {
                Console.WriteLine(item);
            }
        }

        public async Task ListEventWhichIsUsedTicketsAsync()
        {
            var events = await _db.Events.Include(e => e.Tickets).Select(e => new { Name = e.Name, TicketCountIsUsedCount = e.Tickets.Where(t => t.IsUsed == true).ToList().Count, TicketCount = e.Tickets.Count }).ToListAsync();
            foreach (var item in events)
            {
                Console.WriteLine(item);
            }
        }

        public async Task ExecuteCreateEventAsync()
        {
            Console.Write("Event name: ");
            var name = Console.ReadLine()?.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name is required.");
                return;
            }

            DateTime date;
            var dateFormats = new[] { "yyyy-MM-dd", "dd.MM.yyyy", "dd/MM/yyyy", "M/d/yyyy" };
            while (true)
            {
                Console.Write("Event date (yyyy-MM-dd or dd.MM.yyyy): ");
                var input = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Date is required.");
                    continue;
                }

                if (DateTime.TryParseExact(input, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    break;
                }

                Console.WriteLine("Invalid date format. Try again.");
            }

            decimal price;
            while (true)
            {
                Console.Write("Price: ");
                var priceInput = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(priceInput))
                {
                    Console.WriteLine("Price is required.");
                    continue;
                }

                if (decimal.TryParse(priceInput, out price))
                {
                    break;
                }


                Console.WriteLine("Invalid price. Try again.");
            }

            await CreateEventAsync(name, date, price);
            Console.WriteLine("Event created: {0} ({1:yyyy-MM-dd})", name, date);
        }
    }
}