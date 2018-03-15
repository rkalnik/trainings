using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompundtOperators
{
	class Program
	{
		static void Main(string[] args)
		{
			int total = 0;
			int value = 0;

			Console.WriteLine("Please enter a number or -1 to quit: ");
			value = Convert.ToInt32(Console.ReadLine());

			while (value != -1)
			{
				if (value > 5)
				{
					if (value < 15)
					{
						//total = total + value;
						total += value;

						//total = total * value;
						//total *= value;
					}

				}
				else
				{
					//total = total + 1;
					//total += 1;
					total++;
					//++total;

					//total--;
					//total = total - 1;
					//total -= 1;
				}

				Console.WriteLine("Please enter a number or -1 to quit: ");
				value = Convert.ToInt32(Console.ReadLine());

			}

			Console.WriteLine("Total number = {0}", total);
			Console.ReadKey();

		}
	}
}
