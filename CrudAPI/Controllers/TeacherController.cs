using CrudAPI.Entities;
using CrudAPI.IService;
using CrudAPI.Models;
using CrudAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IService_Teacher _service_Teacher;

        public TeacherController(IService_Teacher service_Teacher)
        {
            _service_Teacher = service_Teacher;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll() {
            var result = await _service_Teacher.GetAllTeachers();
            if (result == null) 
            { 
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            return Ok(await _service_Teacher.AddTeacher(teacher));
        }

    }
}
