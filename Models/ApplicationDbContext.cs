using Microsoft.EntityFrameworkCore;

namespace IUTLeague.Models
{
	public class ApplicationDbContext:DbContext
	{
        public ApplicationDbContext(DbContextOptions options):base(options)
        {}

		public DbSet<Admin> Admins { get; set; }

		public DbSet<Player> Players { get; set; }
		public DbSet<Match> Matches { get; set; }
		public DbSet<Team> Teams { get; set; }
	}
}
