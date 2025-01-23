namespace CrudAPI.Entities
{
    public class Mst_Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // Navigation property
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}
