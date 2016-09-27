using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Models;

namespace DataLayer.Initialiazer
{
	public class BlogDbInitializer : DropCreateDatabaseAlways<BlogsDbContext>
	{
		protected override void Seed(BlogsDbContext context)
		{
			var user = new User()
			{
				Name = "Rafal",
				BrithDate = DateTime.Now,
				CreateDate = DateTime.Now,
				LastLoginDate = DateTime.Now,
			};

			var blog = new Blog()
			{
				Name = "blog name",
				Rating = 3,
				CreationDate = DateTime.Now,
				Admin = user
			};

			var post = new Post()
			{
				Title = "Post lolo",
				CreationDate = DateTime.Now,
				Content = "lorem ipsum",
				Blog = blog
			};

			context.Posts.Add(post);
			base.Seed(context);
		}
		
		
	}
}
