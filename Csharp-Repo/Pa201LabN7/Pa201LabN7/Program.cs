using Pa201LabN7.Services;
using System;

var eventService = new EventService();

//for (int i = 1; i <= 5; i++)
//{
//    var ev = await eventService.CreateEventAsync($"Event {i}", DateTime.Now.AddDays(i), 10.0m * i);
//    Console.WriteLine($"Created: {ev}");
//}

//await eventService.UpdateEventAsync(5, "Event 05", DateTime.Now, 90.0m);

//await eventService.GetAllEventsAsync();

//await eventService.DeleteEventAsync(5);


var ticketService = new TicketService();

//await ticketService.GetTicketAsync(4);
//await ticketService.GetTicketAsync(4);
//await ticketService.GetTicketAsync(4);
//await ticketService.GetTicketAsync(4);
//await ticketService.GetTicketAsync(4);

//await ticketService.UsingTicketAsync(1);

//await eventService.ListEventsOrderbyTicketCountDescAsync();

//await eventService.ListEventsOrderByIncomeDescAsync();

//await eventService.ListEventWillBeFutureAsync();

//await eventService.ListEventWhichIsUsedTicketsAsync();

//await eventService.ExecuteCreateEventAsync();

await ticketService.ExecuteGetTicketAsync();



