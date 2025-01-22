using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class Course
    {
        [Required]

        public string Title { get; set; }
       
    }
}
