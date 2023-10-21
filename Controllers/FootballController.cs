using IUTLeague.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace IUTLeague.Controllers
{
    public class FootballController : Controller
    {
		private readonly ApplicationDbContext _context;

		public FootballController(ApplicationDbContext dbContext)
		{
			_context = dbContext;
		}

		public ActionResult Index()
        {
            return View("~/Views/Football/Matches.cshtml");
        }
        

        public IActionResult Stats()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        //Matches
        public static List<Match> GetMatchesFromDataSource(ApplicationDbContext _context)
        {
            return _context.Matches.OrderByDescending(M => M.Id).ToList();
        }
        public ActionResult Matches()
        {
            List<Match> Plays = GetMatchesFromDataSource(_context);
            var sortedMatches = Plays.OrderByDescending(M => M.Id).ToList();
            return View(sortedMatches);
        }

        //players
        public static List<Player> GetPlayersFromDataSource(ApplicationDbContext _context)
        {
			return _context.Players.OrderByDescending(P => P.Goals).ToList();
        }
        public ActionResult Players()
        {
            List<Player> Plays = GetPlayersFromDataSource(_context);
            var sortedPlays = Plays.OrderByDescending(P => P.Goals).ToList();
            return View(sortedPlays);
        }
        
        //standings
        public static List<Team> GetTeamsFromDataSource(ApplicationDbContext _context)
        {
			return _context.Teams.OrderByDescending(T => T.Points).ToList();
        }
        public ActionResult Standings()
        {
            List<Team> stands = GetTeamsFromDataSource(_context);
            var sortedStands = stands.OrderByDescending(T => T.Points).ToList();
            return View(sortedStands);
        }

        //for cache
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
