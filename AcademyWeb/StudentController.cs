using AcademyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcademyWeb
{
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            // i need to work with model to fetch data from database and attach to view
            // to render the content on the browser

            IList<Student> students = new List<Student>();

            // student1 obj
            var student1 = new Student(1, "Sajjad", "sajjad@gmail.com", null, "Dot Net");

            // add obj to list
            students.Add(student1);

            students.Add(new Student(2, "Akram", "akram@gmail.com", null, "JAVA"));
            students.Add(new Student(2, "Khan", "khan@gmail.com", null, "AWS"));

            return View("Dashboard", students);
        }

        public IActionResult CreateStudent()
        {
            return View();
        }

        public IActionResult StudentRO()
        {
            var student1 = new Student(1, "Sajjad", "sajjad@gmail.com", null, "Dot Net");

            return View(student1);
        }

        public IActionResult UpdateStudent()
        {
            return View();
        }

        public IActionResult DeleteStudent()
        {
            return View();
        }
    }
}
