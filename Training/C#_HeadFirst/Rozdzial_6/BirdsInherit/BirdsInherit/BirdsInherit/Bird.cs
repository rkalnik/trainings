using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsInherit
{
	class Bird
	{
		//string BirdName2;

		//public Bird(string birdName2)
		//{
		//	this.BirdName2 = birdName2;
		//}

		//public Bird()
		//{

		//}

		public virtual void Fly()
		{
			Console.WriteLine("Ptaki latają");
		}
		 public void LayEggs()
		{
			Console.WriteLine("Ptaki wysiadują jaja");
		}
	}
}
