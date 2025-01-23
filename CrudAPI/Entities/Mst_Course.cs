namespace CrudAPI.Entities
{
    public class Mst_Course
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        // Navigation properties
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
