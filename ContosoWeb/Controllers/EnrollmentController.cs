using System.Web.Mvc;
using Contoso.Service;

namespace ContosoWeb.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly IEnrollmentService enrollmentService;

        public EnrollmentController()
        {
            enrollmentService = new EnrollmentService();
        }

        // GET: Enrollment
        public ActionResult Index()
        {
            return View(enrollmentService.GetAllEnrollments());
        }
    }
}