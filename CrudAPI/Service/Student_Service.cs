using CrudAPI.Entities;
using CrudAPI.IService;

namespace CrudAPI.Service
{
    public class Student_Service : IService_Student
    {
        public Task<Mst_Student> AddStudent(Mst_Student student)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Mst_Student>> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Task<Mst_Student> GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Mst_Student> UpdateStudent(Mst_Student student)
        {
            throw new NotImplementedException();
        }
    }
}
