using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Models;

namespace DataLayer
{
	public class QuizDBInitializer:DropCreateDatabaseIfModelChanges<QuizDbContext>
	{

		protected override void Seed(QuizDbContext context)
		{
			for (int i = 0; i < 10; i++)
			{
				context.Set<Question>().Add(new Question() { QuestionText = $"Question {i}", Answer = $"Answer {i}" });
			}

			context.SaveChanges();
			base.Seed(context);

		}


	}
}
