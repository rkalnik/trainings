using System;
using System.Linq;
using WinFormsTraining.Database;

namespace WinFormsTraining
{
	public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
			using (var dbContext = new LibraryDbContext())
			{
				//dbContext.Books.Add(new Book() { PublishDate = DateTime.Now });
				//dbContext.SaveChanges();
				var book = dbContext.Books.First();
			}

        }
    }
}