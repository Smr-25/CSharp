
using System.Text;
using ConsoleApp11;

string path = "C:\\Users\\samiraa\\Desktop\\Lab\\ConsoleApp11\\ConsoleApp11\\Files\\";

if (!Directory.Exists(path))
    Directory.CreateDirectory(path);


path += "Database.json";

if (!File.Exists(path))
    File.Create(path);

Department department = new();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Menu");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. Get employee by id");
    Console.WriteLine("3. Remove employee");
    Console.WriteLine("0. Quit");
    Console.WriteLine();
    Console.WriteLine("Please Choose Option");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            department.AddEmployee();
            break;
        case 2:
            department.GetEmployeeById().ShowInfo();
            break;
        case 3:
            department.RemoveEmployee();
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Choose right option");
            break;
    }
}
