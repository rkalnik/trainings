using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
	public class User
	{
		public int UserId { get; set; }
		[MaxLength(200)]
		public string Name { get; set; }
		public DateTime BrithDate { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime LastLoginDate { get; set; }


		public int? AdressId { get; set; }
		[ForeignKey(nameof(AdressId))]
		public virtual UserAdress Adress { get; set; }

	}
}
