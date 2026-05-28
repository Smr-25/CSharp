namespace Pa201LabN7.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public List<Ticket> Tickets { get; set; }

        public override string ToString()
        {
            return $"Event {{ Id = {Id}, Name = {Name}, Date = {Date:yyyy-MM-dd HH:mm}, Price = {Price:C} }}";
        }
    }

}
