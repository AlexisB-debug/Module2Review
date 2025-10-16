namespace Module2Review;

public class Course
{
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    private List<string> EnrolledStudents;

    public Course()
    {
        EnrolledStudents = new List<string>();
    }
}