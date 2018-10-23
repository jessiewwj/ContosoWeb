using Contoso.Model.Models;

namespace Contoso.Data.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface ICourseRepository : IRepository<Course>
    {

    }
}
