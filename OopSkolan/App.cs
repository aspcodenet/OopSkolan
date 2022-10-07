namespace OopSkolan;

public class App
{
    public void Run()
    {
        var course1 = new Course("C#", 200, new DateTime(2022, 8, 12), new DateTime(2022, 10, 12));
        var course2 = new Course("Databasteknik", 400, new DateTime(2022, 10, 12), new DateTime(2022, 12, 31));

        int antalKursDagar = course1.CalculateNumberOfCourseDays();
        int pointsPerDay = course1.PointsPerCourseDay();
    }
}