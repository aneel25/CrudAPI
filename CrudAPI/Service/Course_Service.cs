//using CrudAPI.DB;
//using CrudAPI.Entities;
//using CrudAPI.IService;
//using CrudAPI.Models;
//using Microsoft.EntityFrameworkCore;

//namespace CrudAPI.Service
//{
//    public class Course_Service : IService_Course
//    {
//        private readonly ApplicationDbContext _context;

//        public Course_Service(ApplicationDbContext context)
//        {
//            _context = context;
//        }
//        public async Task<Mst_Course> AddCourse(Course _course)
//        {
//            var course = new Mst_Course();
//            course.Title = _course.Title;
//            _context.Courses.Add(course);
//            await _context.SaveChangesAsync();
//            return course;
//        }

//        public async Task<bool> DeleteCourse(int id)
//        {
//            var course = await _context.Courses.FindAsync(id);
//            if (course == null)
//            { return false; }

//            _context.Courses.Remove(course);
//            await _context.SaveChangesAsync();
//            return true;
//        }

//        public async Task<IEnumerable<Mst_Course>> GetAllCourses()
//        {
//            return await _context.Courses.ToListAsync();
//        }

//        public async Task<Mst_Course> GetCourseById(int id)
//        {
//            return await _context.Courses.FindAsync(id);
//        }

//        //public async Task<Mst_Course> UpdateCourse(int id,Mst_Course course)
//        //{
//        //    var existingcourse = await _context.Courses.FindAsync(id);
//        //    if(existingcourse == null)
//        //    {
//        //        throw new KeyNotFoundException("Course not found.");
//        //    }
//        //    var existingteacher = await _context.Teachers.FindAsync(id);
//        //    if( existingteacher == null)
//        //    {
//        //        throw new KeyNotFoundException("teacher not found.");
//        //    }
//        //    existingcourse.Title = course.Title;
//        //    existingcourse.TeacherId = course.TeacherId;
//        //    await _context.SaveChangesAsync();
//        //    return existingcourse;
//        //}
//    }
//}
