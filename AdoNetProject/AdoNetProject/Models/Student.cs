namespace AdoNetProject.Models;

public class Student
{
    public int  Id { get; set; }

    public string Name { get; set; }

    public string  Email { get; set; }
    
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Email: {Email}, Age: {Age}";
    }
}