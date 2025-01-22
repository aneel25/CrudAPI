using CrudAPI.Entities;

namespace CrudAPI.IService
{
    public interface IService_Course
    {
        Task<IEnumerable<Mst_Course>> GetAllCourses();
        Task<Mst_Course> GetCourseById(int id);
        Task<Mst_Course> AddCourse(Mst_Course course);
        Task<Mst_Course> UpdateCourse(Mst_Course course);
        Task<bool> DeleteCourse(int id);
    }
}
