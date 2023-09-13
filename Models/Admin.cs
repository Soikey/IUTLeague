using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IUTLeague.Models
{
	public class Admin
	{
		[Key]
		public int Id { get; set; }
		
		[Column(TypeName = "nvarchar(50)")]
		public string Name { get; set; }
		
		[Column(TypeName = "nvarchar(20)")]
		public string Email { get; set; }
		
		[Column(TypeName = "nvarchar(15)")]
		public string PhoneNumber { get; set; }
		
		[Column(TypeName = "nvarchar(10)")]
		public string Password { get; set; }
	}
}