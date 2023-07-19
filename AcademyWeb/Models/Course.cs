using Microsoft.Extensions.Primitives;

namespace AcademyWeb.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int DurationInDays { get; set; }
        public decimal? Price { get; set; }

        public Course()
        {

        }

        public Course(int courseId,string courseName,int durationInDays)
        {
            CourseID = courseId;
            CourseName = courseName;
            DurationInDays = durationInDays;
        }

        public Course(int courseID, string courseName, int durationInDays, decimal price)
        {
            CourseID = courseID;
            CourseName = courseName;
            DurationInDays = durationInDays;
            Price = price;
        }
    }
}
