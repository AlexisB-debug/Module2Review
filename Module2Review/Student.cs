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

    static double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0.0d;
        }
        else
        {
            double gradeSum = 0.0d;
            for (int counter = 0; counter <= Grades.Count - 1; counter = counter + 1)
            {
                gradeSum = gradeSum + Grades[counter];
            }
            double gradeAverage = gradeSum / (Grades.Count - 1);
        }
    }
}