using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;

public class CourseManager
{
    //dependency injection
    private readonly ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public List<course> GetAll()
    {
        //business rules

        return _courseDal.GetAll();
    }
}