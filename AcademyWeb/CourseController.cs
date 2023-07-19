using AcademyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcademyWeb
{
    public class CourseController : Controller
    {
        public IActionResult CoursesList()
        {
            //we need to use EF to bring the data from DB 

            IList<Course> courses = new List<Course>();

            var course1 = new Course(1, "Dot Net", 120, 20000);
            courses.Add(course1);

            var course2 = new Course(2, "Core Java", 120, 15000);
            courses.Add(course2);

            courses.Add(new Course(3, "AWS", 45, 10000));
            courses.Add(new Course(4, "DevOps", 60, 12000));
            courses.Add(new Course(5, "Software Testing", 60, 15000));

            return View(courses);
        }
    }
}
