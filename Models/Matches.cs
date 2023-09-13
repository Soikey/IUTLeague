using System.ComponentModel.DataAnnotations;

namespace IUTLeague.Models
{
	public class Matches
	{
		[Key]
		public int Id {  get; set; }
		public int Home_Team { get; set; }
		public int Away_Team { get; set; }
		public int Home_Goals { get; set; }
		public int Away_Goals { get; set; }
	}
}
