namespace CrudAPI.Entities
{
    public class Mst_Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Foreign Key for Teacher
        public int TeacherId { get; set; }
        public Mst_Teacher Teacher { get; set; }

        // Navigation Property
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
