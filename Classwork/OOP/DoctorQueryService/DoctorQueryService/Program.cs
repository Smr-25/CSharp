using ConsoleApp8;

DoctorService dctrService = new DoctorService();

//foreach(var doctor in dctrService.GetAll())
//{

//    Console.WriteLine($"FullName: {doctor.FullName}, Age: {doctor.Age}, Email: {doctor.Email}, Address: {doctor.Address}");
//}
string searchText = Console.ReadLine();

dctrService.SearchByFullName(dctrService.GetAll(), searchText);

string keyValue = Console.ReadLine();

foreach (var doctor in dctrService.SortByAge(dctrService.GetAll(), keyValue))
{

    Console.WriteLine($"FullName: {doctor.FullName}, Age: {doctor.Age}, Email: {doctor.Email}, Address: {doctor.Address}");
}

Console.WriteLine(dctrService.GetAvarageByAge(dctrService.GetAll()));