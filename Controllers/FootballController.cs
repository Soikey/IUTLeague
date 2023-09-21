using IUTLeague.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IUTLeague.Controllers
{
    public class FootballController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Football/F_index.cshtml");
        }
        public ActionResult Players()
        {
            return View();
        }

        public ActionResult Standings()
        {
            return View();
        }

        public IActionResult Stats()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Matches()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
