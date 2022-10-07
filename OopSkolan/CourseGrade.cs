namespace OopSkolan;

public class CourseGrade
{
    public string CourseName { get; }
    public DateTime Date { get; }
    public Grade Grade { get; }

    public CourseGrade(string courseName, DateTime date, Grade grade)
    {
        CourseName = courseName;
        Date = date;
        Grade = grade;
    }
}