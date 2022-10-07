using System.Runtime.CompilerServices;

namespace OopSkolan;

public class Student
{
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _phone;

    public Student(string firstName, string lastName, string email, string phone)
    {
        _firstName = firstName;
        _lastName = lastName;
        _email = email;
        _phone = phone;
    }

    public List<CourseGrade> FetchGrades()
    {
        var l = new List<CourseGrade>();
        l.Add(new CourseGrade("C#", new DateTime(2022,1,1), Grade.G));
        l.Add(new CourseGrade("Databasteknik", new DateTime(2022, 2, 2), Grade.VG));
        return l;
    }
}