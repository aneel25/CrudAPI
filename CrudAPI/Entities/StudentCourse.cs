namespace CrudAPI.Entities
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Mst_Student Student { get; set; }

        public int CourseId { get; set; }
        public Mst_Course Course { get; set; }
    }
}
