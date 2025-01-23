namespace CrudAPI.Entities
{
    public class Mst_Student
    {

        public Guid Id { get; set; }
        public string Name { get; set; }

        // Navigation property
        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
