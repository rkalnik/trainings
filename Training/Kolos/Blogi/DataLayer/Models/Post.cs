using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
	public class Post
	{
		[Key]
		public int PostNumber { get; set; }

		[ForeignKey(nameof(BlogId))]
		public Blog Blog { get; set; }

		public int BlogId { get; set; }

		[MaxLength(200)]
		public string Title { get; set; }

		[StringLength(1000, MinimumLength = 50)]
		public string Content { get; set; }

		public DateTime CreationDate { get; set; }

		[ForeignKey(nameof(AuthorId))]
		public User Author { get; set; }

		public int AuthorId { get; set; }
	}
}
