using Newtonsoft.Json;

namespace ObjectCopy.Models;

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public UserDetail userDetail { get; set; }
    public User ShallowCopy()
    {
       return  this.MemberwiseClone() as User;;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Address: {Address} {userDetail}";
    }

    public User DeepCopy()
    {
        string json = JsonConvert.SerializeObject(this);
        return JsonConvert.DeserializeObject<User>(json);
    }
}

public class UserDetail
{
    public string Phone { get; set; }
    public string Email { get; set; }
}