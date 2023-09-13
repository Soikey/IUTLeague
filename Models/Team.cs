using System.ComponentModel.DataAnnotations;

namespace IUTLeague.Models
{
	public class Team
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Stadium { get; set; }
		public int Points { get; set; }
		public int GoalsConcieved { get; set; }
		public int GoalsScored { get; set;}
		public int GamesPlayed { get; set; }
		public int Wins {  get; set; }
		public int Looses { get; set; }
		public int Draws { get; set; }
	}
}
