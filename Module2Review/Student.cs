namespace Module2Review;

public class Student
{
    public string Name { get; set; } = "";
    public int ID { get; set; } = 0;
    public List<double> Grades { get; set; } = [];

    public static void AddGrade(double grade, Student student)
    {
        student.Grades.Add(grade);
    }

    public static void AddGrade(Student student, params double[] grades)
    {
        student.Grades.AddRange(grades);
    }

    public static double CalculateAverageGrade(Student student)
    {
        // if (Grades.Count == 0)
        // {
        //     return 0;
        // }
        // else
        // {
        //     double gradeSum = 0;
        //     foreach (var grade in Grades)
        //     {
        //         gradeSum = gradeSum + grade;
        //     }
        //     double gradeAverage = gradeSum / (Grades.Count - 1);
        //     return gradeAverage;
        // }
        
        // double averageGrade = Grades.Any() ? Grades.Average() : 0;
        // return averageGrade;
        
        return student.Grades.Average();
    }
}