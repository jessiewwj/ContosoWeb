using Contoso.Model.Models;

namespace Contoso.Data.Repositories
{
    public class EnrollmentRepository : Repository<Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface IEnrollmentRepository : IRepository<Enrollment>
    {
    }
}
