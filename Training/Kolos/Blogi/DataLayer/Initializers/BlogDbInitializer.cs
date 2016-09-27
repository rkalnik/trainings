using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Initializers
{
	public class BlogDbInitializer : DropCreateDatabaseAlways<BlogsDbContext>
	{
		protected override void Seed(BlogsDbContext context)
		{
			var user = new User()
			{
				BirthDate = DateTime.Now,
				CreationDate = DateTime.Now,
				LastLoginDate = DateTime.Now,
				Name = "First User"
			};

			var blog = new Blog()
			{
				CreationDate = DateTime.Now,
				Name = "First Blog",
				Rating = 3,
				Admin = user
			};

			var post = new Post()
			{
				Author = user,
				Blog = blog,
				Content = "This is the best blog EVER! For real! Check our ratings! Dont forget to subscribe. I hope this is 50 characters.",
				CreationDate = DateTime.Now,
				Title = "Best Blog Ever. Really."
			};

			context.Posts.Add(post);

			base.Seed(context);
		}
	}
}
