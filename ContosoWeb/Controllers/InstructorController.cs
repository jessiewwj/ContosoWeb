using System.Web.Mvc;
using Contoso.Service;

namespace ContosoWeb.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorService instructorService;

        public InstructorController()
        {
            instructorService = new InstructorService();
        }

        // GET: Instructor
        public ActionResult Index()
        {
            return View(instructorService.GetAllInstructors());
        }
    }
}