namespace Pa201LabN7.Interfaces
{
    public interface IEventService
    {
        Task CreateEventAsync(string name, DateTime date, decimal price);
        Task DeleteEventAsync(int id);
        Task ExecuteCreateEventAsync();
        Task GetAllEventsAsync();
        Task ListEventsOrderByIncomeDescAsync();
        Task ListEventsOrderbyTicketCountDescAsync();
        Task ListEventWhichIsUsedTicketsAsync();
        Task ListEventWillBeFutureAsync();
        Task UpdateEventAsync(int id, string name, DateTime date, decimal price);
    }
}