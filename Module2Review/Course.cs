namespace Module2Review;

public class Course : Student
{
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course()
    {
        EnrolledStudents = new List<Student>(); ;
    }

    public static void AddStudent(Course course, Student student)
    {
        if (!course.EnrolledStudents.Contains(student)) 
        {
            course.EnrolledStudents.Add(student);
        }
    }
}