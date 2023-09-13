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
		public Team Team { get; set; }
		
		[Column(TypeName = "nvarchar(50)")]
		public string Name { get; set; }
		
		[Column(TypeName = "nvarchar(50)")]
		public string Description { get; set; }
		
		[Column(TypeName = "nvarchar(20)")]
		public string Nation { get; set; }
		
		[Column(TypeName = "int")]
		public int Age { get; set; }
		
		[Column(TypeName = "int")]
		public int Salary { get; set; }
		
		[Column(TypeName = "int")]
		public int Goals { get; set; }
		
		[Column(TypeName = "int")]
		public int Assists { get; set; }
		
		[Column(TypeName = "int")]
		public int YellowCards { get; set;}
		
		[Column(TypeName = "int")]
		public int RedCards { get; set;}
	}
}
