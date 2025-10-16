namespace Module2Review;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        var student1 = new Student()
        {
            Name = "Granger, Hermione Jean",
            ID = 001
        };
        students.Add(student1);
        
        var student2 = new Student()
        {
            Name = "Malfoy, Draco Lucius",
            ID = 002
        };
        students.Add(student2);

        var student3 = new Student()
        {
            Name = "Potter, Harry James",
            ID = 003
        };
        students.Add(student3);

        var student4 = new Student()
        {
            Name = "Weasley, Ronald Bilius",
            ID = 004
        };
        students.Add(student4);
    }
}