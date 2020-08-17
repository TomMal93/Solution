using SimpleSolution.Data.DAL;
using SimpleSolution.Data.Models;
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

            var a = simpleContext.Classrooms.ToList();

            return View("Index", new SimpleViewModel { Text = "TESTOWY TEKST" });
        }
    }
}