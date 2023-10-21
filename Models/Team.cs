using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IUTLeague.Models
{
	public class Team
	{
		[Key]
		public int Id { get; set; }

		/*[Column(TypeName = "nvarchar(255)")]
		public string Logo { get; set; }*/

		[Column(TypeName = "nvarchar(50)")]
		public string Name { get; set; }

		[Column(TypeName = "nvarchar(100)")]
		public string Description { get; set; }

		[Column(TypeName = "nvarchar(25)")]
		public string Stadium { get; set; }

		[Column(TypeName = "int")]
		public int Points { get; set; }
		
		[Column(TypeName = "int")]
		public int GoalsConcieved { get; set; }
		
		[Column(TypeName = "int")]
		public int GoalsScored { get; set;}
		
		[Column(TypeName = "int")]
		public int GamesPlayed { get; set; }
		
		[Column(TypeName = "int")]
		public int Wins {  get; set; }
		
		[Column(TypeName = "int")]
		public int Looses { get; set; }
		
		[Column(TypeName = "int")]
		public int Draws { get; set; }
	}
}
