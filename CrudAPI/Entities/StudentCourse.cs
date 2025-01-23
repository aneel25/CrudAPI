using CrudAPI.Models;

namespace CrudAPI.Entities
{
    public class StudentCourse
    {
        public Guid Id { get; set; } // Primary Key
        public Guid Student_Id { get; set; } // Foreign Key
        public Guid Course_Id { get; set; } // Foreign Key

        // Navigation properties
        public Mst_Student Student { get; set; }
        public Mst_Course Course { get; set; }
    }
}
