using System.Data;
using AdoNetProject.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetProject.Services;

public class StudentService
{
    private readonly string _connectionString =
        "Server=.;Database=Academy;TrustServerCertificate=True;";

    public SqlConnection CreateConnection()
    {
        SqlConnection sqlConnection = new SqlConnection(_connectionString);
        sqlConnection.Open();
        return sqlConnection;
    }

    public void CreateStudent(Student student)
    {
        var connection = CreateConnection();
        //string commandText = $"INSERT INTO Student (Name, Email, Age) VALUES ('{student.Name}','{student.Email}',{student.Age})";
        string commandText = "INSERT INTO Student (Name,Email,Age) VALUES (@Name,@Email,@Age);";
        using SqlCommand sqlCommand = new SqlCommand(commandText, connection);
        sqlCommand.Parameters.AddWithValue("@Name", student.Name);
        sqlCommand.Parameters.AddWithValue("@Email", student.Email);
        sqlCommand.Parameters.AddWithValue("@Age", student.Age);
        int result = sqlCommand.ExecuteNonQuery();
        if (result > 0)
        {
            Console.WriteLine("Student created successfully.");
        }
        else
        {
            Console.WriteLine("Failed to create student.");
        }
    }

    public void UpdateStudent(int id, Student student)
    {
        using var connection = CreateConnection();
        string commandText = "UPDATE Student SET Name=@Name, Email=@Email, Age=@Age WHERE Id=@Id;";
        using SqlCommand sqlCommand = new SqlCommand(commandText, connection);
        sqlCommand.Parameters.AddWithValue("@Name", student.Name);
        sqlCommand.Parameters.AddWithValue("@Email", student.Email);
        sqlCommand.Parameters.AddWithValue("@Age", student.Age);
        sqlCommand.Parameters.AddWithValue("@Id", id);
        int result = sqlCommand.ExecuteNonQuery();
        if (result > 0)
        {
            Console.WriteLine("Student updated successfully.");
        }
        else
        {
            Console.WriteLine("Failed to update student.");
        }
    }

    public void DeleteStudent(int id)
    {
        using var connection = CreateConnection();
        string commandText = "DELETE FROM Student WHERE Id=@Id;";
        using SqlCommand sqlCommand = new SqlCommand(commandText, connection);
        sqlCommand.Parameters.AddWithValue("@Id", id);
        int result = sqlCommand.ExecuteNonQuery();
        if (result > 0)
        {
            Console.WriteLine("Student deleted successfully.");
        }
        else
        {
            Console.WriteLine("Failed to delete student.");
        }
    }

    public Student GetStudentById(int id)
    {
        using var connection = CreateConnection();
        string commandText = "SELECT * FROM Student WHERE Id=@Id;";
        using SqlCommand sqlCommand = new SqlCommand(commandText, connection);
        sqlCommand.Parameters.AddWithValue("@Id", id);
        using SqlDataReader reader = sqlCommand.ExecuteReader();
        if (reader.HasRows)
        {
            if (reader.Read())
            {
                return new Student
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Email = reader.GetString(2),
                    Age = reader.GetInt32(3)
                };
            }
        }

        return null;
    }

    public List<Student> GetAllStudents()
    {
        using var connection = CreateConnection();
        string commandText = "SELECT * FROM Student;";
        using SqlCommand sqlCommand = new SqlCommand(commandText, connection);
        using SqlDataReader reader = sqlCommand.ExecuteReader();
        List<Student> students = new List<Student>();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                students.Add(new Student
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Email = reader.GetString(2),
                    Age = reader.GetInt32(3)
                });
            }
        }

        return students;
    }

    public List<Student> GetAllStudentsWithSearch(string search)
    {
        using var connection = CreateConnection();
        string commandText = "SELECT * FROM Student WHERE Name LIKE '%'+@Search+'%' ;";
        using SqlCommand sqlCommand = new SqlCommand(commandText, connection);
        sqlCommand.Parameters.AddWithValue("@Search", search);
        using SqlDataReader reader = sqlCommand.ExecuteReader();
        List<Student> students = new List<Student>();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                students.Add(new Student
                {
                    Id = reader.GetInt32("Id"),
                    Name = reader.GetString("Name"),
                    Email = reader.GetString("Email"),
                    Age = reader.GetInt32("Age")
                });
            }
        }

        return students;
    }

    public int GetStudentCount()
    {
        using var connection = CreateConnection();
        string commandText = "SELECT COUNT(*) FROM Student;";
        using SqlCommand sqlCommand = new SqlCommand(commandText, connection);
        int count = (int)sqlCommand.ExecuteScalar();
        return count;
    }

    public void GetAllStudentsWithView()
    {
        using var connection = CreateConnection();
        string commandText = "SELECT * FROM vw_Student;";
        using SqlCommand sqlCommand = new SqlCommand(commandText, connection);
        using SqlDataReader reader = sqlCommand.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Console.WriteLine(
                    $"Id: {reader.GetInt32("Id")}, Name: {reader.GetString("Name")}, Email: {reader.GetString("Email")}, Age: {reader.GetInt32("Age")}");
            }
        }
    }

    public List<Student> GetAllStudentsWithStoredProcedure()
    {
        using var connection = CreateConnection();
        string commandText = "usp_GetStudents";
        using SqlCommand sqlCommand = new SqlCommand(commandText, connection);
        sqlCommand.CommandType = CommandType.StoredProcedure;
        using SqlDataReader reader = sqlCommand.ExecuteReader();
        List<Student> students = new List<Student>();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                students.Add(new Student
                {
                    Id = reader.GetInt32("Id"),
                    Name = reader.GetString("Name"),
                    Email = reader.GetString("Email"),
                    Age = reader.GetInt32("Age")
                });
            }
        }

        return students;
    }
}