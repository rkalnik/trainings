using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
	public class Question
	{
		/// <summary>
		/// Jedna z konwencji mowi, ze jezeli w nazwie wlasciwosci bedzie fraza Id np: QuestionId on rozpona to jako PK
		/// Atrybuty dodajemy w nawiazach kwadratowych okreslajace np: dlugosc znakow [MinLenght(10)] jesli QuestionText bedzie mialo
		/// mniej niz 10 znakow to pozwoli wprowadzic tego stringa do bazy i sie wysypie
		/// </summary>
		[Key]
		public int QuestionNumber { get; set; }
		[MinLength(10), MaxLength(200)]
		public string QuestionText { get; set; }
		

		public List<Answer> Answers { get; set; }
	}
}
