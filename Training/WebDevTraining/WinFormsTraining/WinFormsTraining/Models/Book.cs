using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WinFormsTraining.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public int PagesCount { get; set; }
		public DateTime PublishDate { get; set; }
		public Author BookAuthor { get; internal set; }
	}
}