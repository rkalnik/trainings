using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;

namespace QuziF
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var dbContext = new QuizDbContext())
			{
				//try
				//{
				//	dbContext.Questions.Add(new Question() { QuestionText = "Przy" });
				//	dbContext.SaveChanges();
				//}
				//catch(Exception e)
				//{

				//}

				//dbContext.Questions.Add(new Question() { QuestionText = "Przykładowe pytanie", Answer = "Lorem ipsum" });

				dbContext.Questions.Add(new Question() { QuestionText = "Przykładowe długie pytanie" });
				dbContext.SaveChanges();


			}

		}
	}
}
