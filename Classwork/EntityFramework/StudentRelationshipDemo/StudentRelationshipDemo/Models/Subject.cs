namespace ConsoleApp13.Models
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<StudentSubject> StudentSubjects { get; set; }
    }
}
