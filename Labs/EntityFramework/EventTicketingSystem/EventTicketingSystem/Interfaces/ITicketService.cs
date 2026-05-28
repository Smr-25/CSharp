namespace Pa201LabN7.Interfaces
{
    public interface ITicketService
    {
        Task ExecuteGetTicketAsync();
        Task GetTicketAsync(int eventId);
        Task UsingTicketAsync(int ticketId);
    }
}