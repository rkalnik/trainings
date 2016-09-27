using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
	public class Post
	{
		[Key]
		public int PostNumber { get; set; }

		[ForeignKey("BlogId")]
		public virtual Blog Blog { get; set; }
		public int BlogId { get; set; }

		[MaxLength(200)]
		public string Title { get; set; }

		[StringLength(1000, MinimumLength = 5)]
		public string Content { get; set; }
		public DateTime CreationDate { get; set; }
		

		[ForeignKey("AuthorId")]
		public virtual User Author { get; set; }
		public int AuthorId { get; set; }

	}
}
