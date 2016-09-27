using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
	public class User
	{
		public int UserId { get; set; }

		[MaxLength(100)]
		public string Name { get; set; }

		public DateTime BirthDate { get; set; }

		public DateTime CreationDate { get; set; }

		public DateTime LastLoginDate { get; set; }

		[ForeignKey(nameof(AddressId))]
		public UserAddress Address { get; set; }

		public int AddressId { get; set; }
	}
}
