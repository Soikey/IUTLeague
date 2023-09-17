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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
