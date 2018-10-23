using Contoso.Model.Models;

namespace Contoso.Data.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface IStudentRepository : IRepository<Student>
    {
    }
}
