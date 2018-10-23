using Contoso.Model.Models;

namespace Contoso.Data.Repositories
{
    public class OfficeAssignmentRepository : Repository<OfficeAssignment>, IOfficeAssignmentRepository
    {
        public OfficeAssignmentRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface IOfficeAssignmentRepository : IRepository<OfficeAssignment>
    {
    }
}
