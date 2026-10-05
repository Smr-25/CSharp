namespace ConsoleApp13.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }

        public List<StudentSubject> StudentSubjects { get; set; }

        public StudentDetail StudentDetail { get; set; }

    }
}
