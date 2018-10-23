using System.Web.Mvc;
using Contoso.Service;

namespace ContosoWeb.Controllers
{
    public class OfficeAssignmentController : Controller
    {
        private readonly IOfficeAssignmentService officeAssignmentService;

        public OfficeAssignmentController()
        {
            officeAssignmentService = new OfficeAssignmentService();
        }

        // GET: OfficeAssignment
        public ActionResult Index()
        {
            return View(officeAssignmentService.GetAllOfficeAssignments());
        }
    }
}