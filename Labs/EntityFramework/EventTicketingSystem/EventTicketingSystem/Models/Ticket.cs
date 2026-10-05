namespace Pa201LabN7.Models
{
    public  class Ticket
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int EventId { get; set; }

        public bool IsUsed { get; set; } = false;

        public Event Event { get; set; }
        public override string ToString()
        {
            return $"Ticket {{ Id = {Id}, Price = {Price:C} }}";
        }
    }
}
