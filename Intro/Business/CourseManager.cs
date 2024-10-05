using Intro.Entities;

public class CourseManager
{
    //Bu class new methodu eklendiği zaman çalışır.
    public CourseManager()
    {
        course[] courses = new course[3];
        //constructor
        course course1 = new course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET 8";
        course1.Price = 0;

        course course2 = new course();
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = "Java17";
        course2.Price = 0;

        course course3 = new course();
        course3.Id = 3;
        course3.Name = "PHYTON";
        course3.Description = "phyton 3.12";
        course3.Price = 20;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
    // Aşağıdaki bloğa method deniyor.
    public course[] GetAll()
    {
        return courses;
    }
}