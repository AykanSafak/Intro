using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    List<course> courses;
    public CourseDal()
    {
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

        courses = new List<course> { course1, course2, course3  };
    }
    public List<course> Getall()
    {
        return courses;
    }
    public void Add(course course)
    {
        courses.Add(course);
    }
}
