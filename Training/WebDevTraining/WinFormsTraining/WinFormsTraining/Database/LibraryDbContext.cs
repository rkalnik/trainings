using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WinFormsTraining.Models;

namespace WinFormsTraining.Database
{
	public class LibraryDbContext:DbContext
	{
		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }

		public LibraryDbContext()
		{
			System.Data.Entity.Database.SetInitializer<LibraryDbContext>(new LibraryInitializer());
		}
	}
}