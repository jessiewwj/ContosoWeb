using Contoso.Model.Models;

namespace Contoso.Data.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(ContosoDbContext db) : base(db)
        {
        }
    }

    public interface IRoleRepository : IRepository<Role>
    {
    }
}
