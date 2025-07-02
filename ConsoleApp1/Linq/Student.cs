namespace ConsoleApp1.Linq
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> Grades { get; set; }
    }

    public class Eminent
    {
        public string Name { get; set; }

        public double AverageGrade { get; set; }
    }
}
