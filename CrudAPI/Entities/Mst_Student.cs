namespace CrudAPI.Entities
{
    public class Mst_Student
    {

        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Property
        public ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
