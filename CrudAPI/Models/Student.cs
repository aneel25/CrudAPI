using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int CourseId { get; set; }
    }
}
