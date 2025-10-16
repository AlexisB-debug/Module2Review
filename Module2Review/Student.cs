namespace Module2Review;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades { get; set; }
    List<double> grades =new List<double>();

    static void AddGrade(double grade)
    {
    }

    static void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }
}