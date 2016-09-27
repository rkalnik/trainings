using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
	public class UserAddress
	{
		[Key]
		public int UserAddressId { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
	}
}
