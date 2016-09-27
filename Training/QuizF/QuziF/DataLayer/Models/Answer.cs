using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
	public class Answer
	{
		public int AnswerId { get; set; }
		public string AnswerText { get; set; }
		public bool IsCorrect { get; set; }
		public int Value { get; set; }

		//[Range(1,5)]
		//public int DifficultyLevel { get; set; }

		public int? QuestionId { get; set; }
		public virtual Question Question { get; set; }
	}
}
