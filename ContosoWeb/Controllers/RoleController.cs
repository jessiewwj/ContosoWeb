using System.Web.Mvc;
using Contoso.Service;

namespace ContosoWeb.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService roleService;

        public RoleController()
        {
            roleService = new RoleService();
        }

        // GET: Role
        public ActionResult Index()
        {
            return View(roleService.GetAllRoles());
        }
    }
}