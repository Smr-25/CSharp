using System.Text.Json;

namespace ConsoleApp11
{
    internal class Department
    {
        public string path = "C:\\Users\\samiraa\\Desktop\\Lab\\ConsoleApp11\\ConsoleApp11\\Files\\Database.json";
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; } = [];

        public void AddEmployee()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter salary");
            int salary = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee(name, salary);

            Employees.Add(employee);
            using FileStream fileStream = new(path, FileMode.Create);
            using StreamWriter streamWriter = new StreamWriter(fileStream);

            string datas = JsonSerializer.Serialize(Employees);
            streamWriter.Write(datas);
        }

        public Employee GetEmployeeById()
        {
            Console.WriteLine("Input id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            using FileStream fileStream = new(path, FileMode.Open);
            using StreamReader streamReader = new StreamReader(fileStream);
            string result = streamReader.ReadToEnd();

            Employees = JsonSerializer.Deserialize<List<Employee>>(result);

            return Employees.FirstOrDefault(e => e.Id == id) ?? throw new NullReferenceException("Data notfound");
        }

        public void RemoveEmployee()
        {
            Employee employee =  GetEmployeeById();
            Employees.Remove(employee);
            using FileStream fileStream = new(path, FileMode.Create);
            using StreamWriter streamWriter = new StreamWriter(fileStream);
            
            string datas = JsonSerializer.Serialize(Employees);
            streamWriter.Write(datas);

        }
    }
}
