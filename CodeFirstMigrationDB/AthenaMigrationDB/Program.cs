using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaMigrationDB
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new Model.BlogContext())
			{
				db.Blogs.Add(new Model.Blog { Name = "Another Blog " });
				db.SaveChanges();

				foreach (var blog in db.Blogs)
				{
					Console.WriteLine(blog.Name);
				}
			}

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	} 
}
