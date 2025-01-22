using CrudAPI.DB;
using CrudAPI.Entities;
using CrudAPI.IService;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Service
{
    public class Student_Service : IService_Student
    {
        private readonly ApplicationDbContext _context;

        public Student_Service(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Mst_Student> AddStudent(Mst_Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync(); 
            return student;
        }

        public async Task<IEnumerable<Mst_Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Mst_Student> GetStudentById(int id)
        {
            return await _context.Students.FindAsync(id);
        }
        public async Task<bool> DeleteStudent(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return false;
            }
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return true;
        }



        public async Task<Mst_Student> UpdateStudent(Mst_Student student)
        {
            _context.Entry(student).State = EntityState.Modified;   
            await _context.SaveChangesAsync();
            return student;
        }
    }
}
