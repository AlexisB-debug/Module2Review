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
        student1.AddGrade(93.7d);
        student1.AddGrade(97.5d, 96.3d, 91.9d);
        student1.AddGrade(99.7d);
        
        var student2 = new Student()
        {
            Name = "Malfoy, Draco Lucius",
            ID = 002
        };
        students.Add(student2);
        student2.AddGrade(85.9d);
        student2.AddGrade(83.6d,91.3d,87.9d);
        student2.AddGrade(87.1d);

        var student3 = new Student()
        {
            Name = "Potter, Harry James",
            ID = 003
        };
        students.Add(student3);
        student3.AddGrade(87.6d);
        student3.AddGrade(83.1d, 85.9d, 90.1d);
        student3.AddGrade(85.0d);

        var student4 = new Student()
        {
            Name = "Weasley, Ronald Bilius",
            ID = 004
        };
        students.Add(student4);
        student4.AddGrade(70.9d);
        student4.AddGrade(77.3d, 73.5d, 79.0d);
        student4.AddGrade(67.0d);
    }
}