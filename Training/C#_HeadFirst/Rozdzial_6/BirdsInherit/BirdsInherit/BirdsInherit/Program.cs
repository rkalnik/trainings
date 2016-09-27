using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsInherit
{
	class Program
	{
		static void Main(string[] args)
		{
			Penguin bird1 = new Penguin();


			Pigeon harriet = new Pigeon();
			Penguin izzy = new Penguin();



			harriet.Fly();
			harriet.Coo();

			izzy.Fly();

		}
	}
}
