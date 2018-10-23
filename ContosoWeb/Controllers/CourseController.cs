using System.Web.Mvc;
using Contoso.Service;

namespace ContosoWeb.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;

        public CourseController()
        {
            courseService = new CourseService();
        }

        // GET: Course
        public ActionResult Index()
        {
            return View(courseService.GetAllCourses());
        }
    }
}