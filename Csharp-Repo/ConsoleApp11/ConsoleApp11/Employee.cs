namespace ConsoleApp11
{
    internal class Employee
    {
        private static int _id;
        public Employee(string name, int salary)
        {
            _id++;
            Id = _id;
            Name = name;
            Salary = salary;
        }

        public  int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Id} {Name} {Salary}");
        }
    }
}
