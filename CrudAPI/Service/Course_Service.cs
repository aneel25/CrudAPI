using CrudAPI.DB;
using CrudAPI.Entities;
using CrudAPI.IService;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Service
{
    public class Course_Service : IService_Course
    {
        private readonly ApplicationDbContext _context;

        public Course_Service(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Mst_Course> AddCourse(Mst_Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return course;
        }

        public async Task<bool> DeleteCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null) return false;

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Mst_Course>> GetAllCourses()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Mst_Course> GetCourseById(int id)
        {
            return await _context.Courses.FindAsync(id);
        }

        public Task<Mst_Course> UpdateCourse(Mst_Course course)
        {
            throw new NotImplementedException();
        }
    }
}
