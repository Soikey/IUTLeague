using IUTLeague.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
//using System.Web.Security;

namespace IUTLeague.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult AdminLogin()
        {
            return View();
        }
        public IActionResult AdminVerify()
        {
            // Get the username and password from the request.
            string username = Request.Form["username"];
            string password = Request.Form["password"];

            // Call the verification method in the AdminController.
            AdminController adminController = new AdminController(_context);
            bool isAuthenticated = adminController.VerifyCredentials(username, password);

            if (isAuthenticated)
            {
                // If authentication is successful, check if the user is an admin.
                // Use a database query or any other method to determine if the user is an admin.
                bool isAdmin = false; // Set this based on your logic.

                // If the user is an admin, redirect the user to the Admin/Dashboard view.
                if (isAdmin)
                {
                    return RedirectToAction("Dashboard", "Admin");
                }
            }

            // Otherwise, redirect the user to the Home/Index view or show an error message.
            return RedirectToAction("Index", "Home");
        }
    }
}