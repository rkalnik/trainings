using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Models;

namespace DataLayer
{
	public class QuizDbContext : DbContext
	{
		//typ generyczny
		public DbSet<Question> Questions { get; set; }

		public QuizDbContext() : base()
		{
			Database.SetInitializer<QuizDbContext>(new QuizDBInitializer());
		}
	}
}
