using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
	public class Blog
	{
		[Key]
		public int BlogId { get; set; }

		[StringLength(100, MinimumLength = 10)]
		public string Name { get; set; }

		[Range(1.0, 5.0)]
		public int Rating { get; set; }

		public DateTime CreationDate { get; set; }

		[ForeignKey(nameof(AdminId))]
		public User Admin { get; set; }

		public int AdminId { get; set; }
	}
}