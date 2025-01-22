namespace CrudAPI.Entities
{
    public class Mst_Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Property
        public ICollection<Mst_Course> Courses { get; set; }
    }
}
