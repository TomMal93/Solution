using SimpleSolution.Data.DAL;
using SimpleSolution.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace SimpleSolution.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private SimpleContext simpleContext = new SimpleContext();

        public ActionResult Index()
        {

            var classrooms = simpleContext.Classrooms.ToList();
            var students = simpleContext.Students.ToList();

            var viewModel = new HomeViewModel
            {
                Classrooms = classrooms,
                Students = students
            };

            return View("Index", viewModel);
        }
    }
}