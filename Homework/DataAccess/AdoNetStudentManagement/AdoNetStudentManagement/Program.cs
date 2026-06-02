using AdoNetProject.Models;
using AdoNetProject.Services;

namespace AdoNetProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        StudentService studentService = new StudentService();
        using var connection = studentService.CreateConnection();
        // studentService.CreateStudent(new Student()
        // {
        //     Name = "John Doe",
        //     Email = "test@gmail.com",
        //     Age = 23
        // });

        // studentService.UpdateStudent(1, new Student()
        // {
        //     Name = "Jane Doe",
        //     Email = "test2@gmail.com",
        //     Age = 22
        // });

        //studentService.DeleteStudent(3);
        //Console.WriteLine(studentService.GetStudentById(2));
        // foreach (var item in studentService.GetAllStudents())
        //     Console.WriteLine(item);
        //

        //foreach (var item in studentService.GetAllStudentsWithSearch("j"))
        //    Console.WriteLine(item);

        //Console.WriteLine(studentService.GetStudentCount());
        
        //studentService.GetAllStudentsWithView();

        // foreach (var item in  studentService.GetAllStudentsWithStoredProcedure())
        //     Console.WriteLine(item);
        
        
    }
}