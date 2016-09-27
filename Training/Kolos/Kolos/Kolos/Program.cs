using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace Kolos
{
	class Program
	{
		static void Main(string[] args)
		{
			using(var context = new BlogsDbContext())
			{
				context.Users.First();
				context.SaveChanges();
			}
		}
	}
}
