using SimpleSolution.ViewModels;
using System.Web.Mvc;

namespace SimpleSolution.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Index", new SimpleViewModel { Text = "TESTOWY TEKST" });
        }
    }
}