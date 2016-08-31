using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer.Models;

namespace DataLayer
{
	public class QuizDBInitializer:DropCreateDatabaseAlways<QuizDbContext>
	{
				
		protected override void Seed(QuizDbContext context)
		{
			var question = new Question() { QuestionText = "Pierwsze pytanie" };

			for (int i = 0; i < 10; i++)
			{
				context.Answers.Add(new Answer() { AnswerText = $"Odpowiedź {i}", IsCorrect = i == 0, Question = question });
			}

			context.SaveChanges();
			base.Seed(context);

		}


	}
}
