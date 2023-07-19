namespace AcademyWeb.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set;}
        public string StudentEmail { get; set;}
        public string? StudentPhone { get; set; }
        public string Course { get; set; }

        public Student()
        {

        }

        public Student(
            int studentId, 
            string studentName, 
            string studentEmail, 
            string? studentPhone, 
            string course)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentEmail = studentEmail;
            StudentPhone = studentPhone;
            Course = course;
        }
    }
}
