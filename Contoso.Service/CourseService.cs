using Contoso.Model.Models;
using System.Collections.Generic;
using Contoso.Data.Repositories;
using Contoso.Data;


namespace Contoso.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        public CourseService()
        {
            courseRepository = new CourseRepository(new ContosoDbContext());
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return courseRepository.GetAll();
        }

        public Course GetCourseById(int Id)
        {
            return courseRepository.GetById(Id);
        }

        public void CreateCourse(Course course)
        {
            courseRepository.Add(course);
            courseRepository.SaveChanges();

        }
        public void UpdateCourse(Course course)
        {
            courseRepository.Update(course);
            courseRepository.SaveChanges();
        }
    }

    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();

        Course GetCourseById(int Id);
        void CreateCourse(Course course);
        void UpdateCourse(Course course);
    }
}

