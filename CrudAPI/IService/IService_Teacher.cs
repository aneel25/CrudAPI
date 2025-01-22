using CrudAPI.Entities;
using CrudAPI.Models;

namespace CrudAPI.IService
{
    public interface IService_Teacher
    {
        Task<IEnumerable<Mst_Teacher>> GetAllTeachers();
        Task<Mst_Teacher> GetTeacherById(int id);
        Task<Mst_Teacher> AddTeacher(Teacher _teacher);
        Task<Mst_Teacher> UpdateTeacher(int id, Mst_Teacher teacher);
        Task<bool> DeleteTeacher(int id);
    }
}
