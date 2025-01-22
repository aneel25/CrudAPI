using CrudAPI.Entities;

namespace CrudAPI.IService
{
    public interface IService_Teacher
    {
        Task<IEnumerable<Mst_Teacher>> GetAllTeachers();
        Task<Mst_Teacher> GetTeacherById(int id);
        Task<Mst_Teacher> AddTeacher(Mst_Teacher teacher);
        Task<Mst_Teacher> UpdateTeacher(Mst_Teacher teacher);
        Task<bool> DeleteTeacher(int id);
    }
}
