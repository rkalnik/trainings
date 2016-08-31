using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Models;
using DataLayer.Conventions;

namespace DataLayer
{
	public class QuizDbContext : DbContext
	{
		//typ generyczny
		public DbSet<Question> Questions { get; set; }
		public DbSet<Answer> Answers { get; set; }

		//public QuizDbContext() : base()
		//{
		//	Database.SetInitializer<QuizDbContext>(new QuizDBInitializer());
		//}

		public QuizDbContext() : base()
		{
			Database.SetInitializer(new QuizDBInitializer());
		}

		/// <summary>
		/// Model tworzacy baze danych
		/// </summary>
		/// <param name="modelBuilder"></param>
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Add<CustomTableNameConventions>();
			base.OnModelCreating(modelBuilder);
		}

	}

}
