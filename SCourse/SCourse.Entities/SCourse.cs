namespace SCourse.Entities
{
    public class Course
    {
        public int SCourseId { get; set; }   // MUST be int
        public string? CourseName { get; set; }
        public string? CourseCode { get; set; }
        public decimal? Fee { get; set; }
    }
}