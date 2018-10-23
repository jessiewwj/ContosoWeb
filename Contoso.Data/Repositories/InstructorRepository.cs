using Contoso.Model.Models;

namespace Contoso.Data.Repositories
{
    public class InstructorRepository : Repository<Instructor>, IInstructorRepository
    {
        public InstructorRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface IInstructorRepository : IRepository<Instructor>
    {
    }
}
