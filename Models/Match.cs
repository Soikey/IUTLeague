using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IUTLeague.Models
{
	public class Match
	{
		[Key]
		public int Id {  get; set; }
		
		[Column(TypeName = "int")]
		public int Home_Team { get; set; }

		public DateTime Schedulled { get; set; }
		
		[Column(TypeName = "int")]
		public int Away_Team { get; set; }
		
		[Column(TypeName = "int")]
		public int Home_Goals { get; set; }
		
		[Column(TypeName = "int")]
		public int Away_Goals { get; set; }
	}
}
