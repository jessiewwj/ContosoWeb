using Contoso.Model.Models;

namespace Contoso.Data.Repositories
{
    public class PeopleRepository : Repository<People>, IPeopleRepository
    {
        public PeopleRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface IPeopleRepository : IRepository<People>
    {
    }
}