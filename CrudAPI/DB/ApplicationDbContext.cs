using CrudAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Mst_Teacher> Teachers { get; set; }
        public DbSet<Mst_Student> Students { get; set; }
        public DbSet<Mst_Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherCourse>()
                .HasKey(tc => tc.Id);

            modelBuilder.Entity<TeacherCourse>()
                .HasOne(tc => tc.Teacher)  
                .WithMany(t => t.TeacherCourses)
                .HasForeignKey(tc => tc.Teacher_Id);
             
            modelBuilder.Entity<TeacherCourse>()
                .HasOne(tc => tc.Course)
                .WithMany(c => c.TeacherCourses)
                .HasForeignKey(tc => tc.Course_Id);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => sc.Id);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.Student_Id);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.Course_Id);
        }

    }
}

