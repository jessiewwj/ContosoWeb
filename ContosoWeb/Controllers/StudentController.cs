using System.Web.Mvc;
using Contoso.Service;

namespace ContosoWeb.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;

        public StudentController()
        {
            studentService = new StudentService();
        }

        // GET: Student
        public ActionResult Index()
        {
            return View(studentService.GetAllStudents());
        }
    }
}