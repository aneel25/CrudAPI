using CrudAPI.Entities;

namespace CrudAPI.IService
{
    public interface IService_Student
    {
        Task<IEnumerable<Mst_Student>> GetAllStudents();
        Task<Mst_Student> GetStudentById(int id);
        Task<Mst_Student> AddStudent(Mst_Student student);
        Task<Mst_Student> UpdateStudent(Mst_Student student);
        Task<bool> DeleteStudent(int id);
    }
}
