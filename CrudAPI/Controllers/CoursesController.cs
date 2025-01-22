using CrudAPI.IService;
using CrudAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IService_Course _service_Course;

        public CoursesController(IService_Course service_Course)
        {
            _service_Course = service_Course;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Course course)
        {
            return Ok(await _service_Course.AddCourse(course));
        }
    }
}
