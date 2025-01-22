using CrudAPI.DB;
using CrudAPI.Entities;
using CrudAPI.IService;
using CrudAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Service
{
    public class Teacher_Service : IService_Teacher
    {
        private readonly ApplicationDbContext _context;
        public Teacher_Service(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Mst_Teacher> AddTeacher(Teacher _teacher)
        {
            var teacher = new Mst_Teacher(); 
            teacher.Name = _teacher.Name;

            await _context.Teachers.AddAsync(teacher); 
            await _context.SaveChangesAsync();

            return teacher;
        }

        //public async Task<Mst_Teacher> AddTeacher(Mst_Teacher teacher)
        //{
        //    _context.Teachers.Add(teacher);
        //    await _context.SaveChangesAsync();
        //    return teacher;
        //}

        public async Task<IEnumerable<Mst_Teacher>> GetAllTeachers()
        {
            return await _context.Teachers.ToListAsync();
        }

        public async Task<Mst_Teacher> GetTeacherById(int id)
        {
            return await _context.Teachers.FindAsync(id);
        }

        public async Task<Mst_Teacher> UpdateTeacher(int id, Mst_Teacher teacher)
        {
            var existingTeacher = await _context.Teachers.FindAsync(id);
            if (existingTeacher == null)
            {
                throw new KeyNotFoundException("Teacher not found.");
            }
            
            existingTeacher.Name = teacher.Name;

            await _context.SaveChangesAsync();
            return existingTeacher;
        }


        public async Task<bool> DeleteTeacher(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null) { 
                return false;
            }
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return true;
        }



     

        
    }
}
