using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
	public class Blog
	{
		[Key]
		public int BlogId { get; set; }

		[StringLength(100, MinimumLength = 1)]
		public string Name { get; set; }

		[Range(1.0, 5.0)]
		public int Rating { get; set; }
		public DateTime CreationDate { get; set; }

		[ForeignKey("AdminId")]
		//[ForeignKey(nameof(AdminId))]
		public virtual User Admin { get; set; }
		public int AdminId { get; set; }

		public virtual List<Post> Posts { get; set; }

		public string SecondaryName { get; set; }

		public string  Subtitle { get; set; }
	}
}