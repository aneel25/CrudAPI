using CrudAPI.Models;

namespace CrudAPI.Entities
{
    public class TeacherCourse
    {
        public Guid Id { get; set; } 
        public Guid Teacher_Id { get; set; } 
        public Guid Course_Id { get; set; } 

        
        public Mst_Teacher Teacher { get; set; }
        public Mst_Course Course { get; set; }
    }
}
