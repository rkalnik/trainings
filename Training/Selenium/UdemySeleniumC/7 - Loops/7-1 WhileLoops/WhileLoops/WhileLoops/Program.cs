using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
	class Program
	{
		static void Main(string[] args)
		{
			int product = 3;

			while(product <= 100)
			{
				product = 3 * product;
				Console.WriteLine(product);
			}

			Console.ReadKey();

		}
	}
}
