namespace Module2Review;

class Program
{
    static void Main(string[] args)
    {
        // Student student = new Student();
        List<Student> students = new List<Student>();
        
        // foreach(var student in students)
        // {
        //     Console.WriteLine($"Name: {student.Name}\nID: {student.ID}\nGrades:");
        //     foreach (var grade in student.Grades)
        //     {
        //         Console.WriteLine($"{grade}\n");
        //     }
        //     Console.WriteLine($"Average Grade: {AddGrade(grades)}");
        // }

        Course potions = new Course()
        {
            CourseName = "Potions101",
            CourseCode = "POT100",
            Name = "Malfoy, Draco Lucius, Potter, Harry James"
        };

        var student1 = new Student()
        {
            Name = "Granger, Hermione Jean",
            ID = 001
        };
        // students.Add(student1);
        Student.AddGrade(student1,93.7);
        Student.AddGrade(student1,97.5, 96.3, 91.9);
        Student.AddGrade(student1,99.7);
        var student2 = new Student()
        {
            Name = "Malfoy, Draco Lucius",
            ID = 002
        };
        // students.Add(student2);
        Student.AddGrade(student2,85.9);
        Student.AddGrade(student2, 83.6,91.3,87.9);
        Student.AddGrade(student2,87.1);
        Course.AddStudent(potions, student2);
        var student3 = new Student()
        {
            Name = "Potter, Harry James",
            ID = 003
        };
        // students.Add(student3);
        Student.AddGrade(student3,87.6);
        Student.AddGrade(student3,83.1, 85.9, 90.1);
        Student.AddGrade(student3,85.0);
        Course.AddStudent(potions, student3);
        var student4 = new Student()
        {
            Name = "Weasley, Ronald Bilius",
            ID = 004
        };
        // students.Add(student4);
        Student.AddGrade(student4, 70.9);
        Student.AddGrade(student4, 77.3, 73.5, 79.0);
        Student.AddGrade(student4, 67.0);
        
        students.AddRange([student1,student2,student3,student4]);
        foreach (var item in students)
        {
            Console.WriteLine($"Name: {item.Name}\nID: {item.ID}");
            foreach (double grade in item.Grades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine("Average Grade:");
            Console.WriteLine(Math.Round(Student.CalculateAverageGrade(item), 3));
        }
        Console.WriteLine(potions.CourseName, potions.CourseCode);
        foreach (Student item in potions.EnrolledStudents)
        {
            Console.WriteLine($"Name: {item.Name}\nID: {item.ID}");
        }
    }
}