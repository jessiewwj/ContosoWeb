using System.Web.Mvc;
using Contoso.Service;

namespace ContosoWeb.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleService peopleService;

        public PeopleController()
        {
            peopleService = new PeopleService();
        }

        // GET: People
        public ActionResult Index()
        {
            return View(peopleService.GetAllPeople());
        }
    }
}