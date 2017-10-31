using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinFormsTraining.Models
{
	public class Author
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public virtual Author BookAuthor { get; set; }

		public ICollection<Book> Books { get; set; }
	}
}