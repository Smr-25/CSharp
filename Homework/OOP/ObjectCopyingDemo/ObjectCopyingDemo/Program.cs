using ObjectCopy.Models;
using Newtonsoft.Json;
namespace ObjectCopy;

class Program
{
    static void Main(string[] args)
    {
        User user = new User()
        {
            Name = "John Doe",
            Age = 30,
            Address = "123 Main St",
            userDetail = new UserDetail()
            {
            Phone = "123-456-7890",
            Email = "xyz@gmail.com"
            }
        };

        // User user2 = new User()
        // {
        //     Name = user.Name,
        //     Age = user.Age,
        //     Address = user.Address
        // };
        // Console.WriteLine(user==user2); // False
        //
        // User user3 = user; // Reference copy
        // Console.WriteLine(user==user3); // True
        // user3.Name = "Jane Doe";
        //
        // Console.WriteLine(user.Name); // Jane Doe
        //
        User user4 = user.ShallowCopy(); // Shallow copy
        // Console.WriteLine(user==user4); // False
        //user4.Name = "John Smith";
        //Console.WriteLine(user.Name); // Jane Doe
        //Console.WriteLine(user4.Name); // John Smith
        user4.userDetail.Email = "456 Elm St";
        Console.WriteLine(user.userDetail.Email); // 456 Elm St
        Console.WriteLine(user4.userDetail.Email); // 456 Elm St
        string json = JsonConvert.SerializeObject(user);
        User user5 = JsonConvert.DeserializeObject<User>(json);
        Console.WriteLine(user==user5); // False
        User user6 = user.DeepCopy();
        
    }
}