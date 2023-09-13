using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IUTLeague.Models
{
	public class Player
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("TeamId")]
		public int TeamID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Nation { get; set; }
		public int Age { get; set; }
		public int Salary { get; set; }
		public int Goals { get; set; }
		public int Assists { get; set; }
		public int YellowCards { get; set;}
		public int RedCards { get; set;}
	}
}
