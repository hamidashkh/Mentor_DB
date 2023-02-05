namespace Mentor_DB.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get;set; }
        public string TeacherName { get; set; }
        public string TeacherImage { get; set; }
        public int Price { get; set; }
        public int Heart { get; set; }
        public int Likes { get; set; }

    }
}
