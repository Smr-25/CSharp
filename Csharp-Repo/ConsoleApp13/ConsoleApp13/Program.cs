
using ConsoleApp13.Models;
using ConsoleApp13.Data;

namespace OrmEfProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TestDbContext dbContext = new TestDbContext();
        #region List
        //var groups = dbContext.Groups.Where(g => g.Limit > 15).ToList();
        //foreach (var item in groups)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region SingleOrDefault
        //var group = dbContext.Groups.FirstOrDefault(g => g.Id == 2);
        //var group = dbContext.Groups.FirstOrDefault(g => g.Id == 1);
        //Console.WriteLine(group);
        #endregion

        #region Add Update Delete

        //Group newGroup = new Group()
        //{
        //    Name = "Group 4",
        //    Description = "Description 4",
        //    Limit = 40
        //};
        //dbContext.Groups.Add(newGroup);
        //dbContext.SaveChanges();

        //List<Group> groupsToAdd = new List<Group>()
        // {
        //     new Group()
        //     {
        //         Name = "Group 5",
        //         Description = "Description 5",
        //         Limit = 50
        //     },
        //     new Group()
        //     {
        //         Name = "Group 6",
        //         Description = "Description 6",
        //         Limit = 60
        //     }
        // };
        //dbContext.Groups.AddRange(groupsToAdd);
        //dbContext.SaveChanges();

        //var groupToDelete = dbContext.Groups.Find(3);
        //if (groupToDelete == null)
        //{
        //    dbContext.Groups.Remove(groupToDelete);
        //    dbContext.SaveChanges();
        //}

        //var groupToUpdate = dbContext.Groups.Find(2);
        //if (groupToUpdate != null)
        //{
        //    groupToUpdate.Limit = 10;
        //    dbContext.Update(groupToUpdate);
        //    dbContext.SaveChanges();
        //}


        #endregion

        #region AddStudent
        Student student = new Student()
        {
            Name = "Test",
            Age = 20,
            Email = "test@gmail.com",
            GroupId = 1
        };
        dbContext.Students.Add(student);    
        dbContext.SaveChanges();

        List<Student> students = new List<Student>
        {
            new Student()
            {
                Name = "Test2",
                Age = 21,
                Email = "lorem",
                GroupId = 1
            },

            new Student()
            {
                Name = "Test3",
                Age = 22,
                Email = "test3",
                GroupId = 2
            }
        };

        dbContext.Students.AddRange(students);
        dbContext.SaveChanges();
        #endregion

    }
}