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
				dbContext.Questions.Add(new Question() { QuestionText = "Przykładowe pytanie", Answer = "Lorem ipsum" });
				dbContext.SaveChanges();


			}

		}
	}
}
