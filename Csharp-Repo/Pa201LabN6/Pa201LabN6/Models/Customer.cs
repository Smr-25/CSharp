namespace Pa201LabN6.Models
{
    internal class Customer
    {
        private static int _id;

        public Customer(int id, string name, string city)
        {
            _id++;  
            Id = _id;
            Name = name;
            City = city;
        }

        public int Id { get; set; }
        public string  Name { get; set; }

        public string City { get; set; }


    }
}
