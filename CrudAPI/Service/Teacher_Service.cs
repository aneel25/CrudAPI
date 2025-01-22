using CrudAPI.Entities;
using CrudAPI.IService;

namespace CrudAPI.Service
{
    public class Teacher_Service : IService_Teacher
    {
        public Task<Mst_Teacher> AddTeacher(Mst_Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTeacher(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Mst_Teacher>> GetAllTeachers()
        {
            throw new NotImplementedException();
        }

        public Task<Mst_Teacher> GetTeacherById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Mst_Teacher> UpdateTeacher(Mst_Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
