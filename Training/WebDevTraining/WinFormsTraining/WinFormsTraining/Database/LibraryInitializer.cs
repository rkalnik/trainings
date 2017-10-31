using System;
using System.Collections.Generic;
using System.Data.Entity;
using WinFormsTraining.Models;

namespace WinFormsTraining.Database
{
	internal class LibraryInitializer : DropCreateDatabaseAlways<LibraryDbContext>
	{
		protected override void Seed(LibraryDbContext context)
		{
			var author = new Author()
			{
				BirthDate = DateTime.Today,
				FirstName = "Stefan",
				LastName = "Marcinkiewicz"
			};

			var book = new Book()
			{
				BookAuthor = author,
				PagesCount = 1000,
				PublishDate = DateTime.UtcNow,
				Title = "Jak zostać kimś"
			};

			author.Books = new List<Book> { book };

			context.Authors.Add(author);
			context.Books.Add(book);
			context.SaveChanges();

			base.Seed(context);
		}

	}
}