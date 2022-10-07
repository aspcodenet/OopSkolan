using System.ComponentModel;

namespace OopSkolan;

public class Course
{
    private string _name;
    private int _points;
    private DateTime _startDateTime;
    private  DateTime _endDateTime;

    public Course(string name, int points, DateTime startDateTime, DateTime endDateTime)
    {
        _name = name;
        _points = points;
        _startDateTime = startDateTime;
        _endDateTime = endDateTime;
    }

    public int CalculateNumberOfCourseDays()
    {
        var d = _startDateTime;
        var antalRegularDays = 0;
        while (d <= _endDateTime)
        {
            if (d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday)
                antalRegularDays++;
            d = d.AddDays(1);
        }

        return antalRegularDays;
    }

    public int PointsPerCourseDay()
    {
        return Convert.ToInt32(  Convert.ToSingle(_points)/   CalculateNumberOfCourseDays());
    }
}