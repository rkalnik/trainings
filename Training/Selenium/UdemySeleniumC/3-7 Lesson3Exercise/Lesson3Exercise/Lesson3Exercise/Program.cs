using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;

            Console.WriteLine(num1 + " " + num2 + " " + num3 + " " + num4);

            Console.WriteLine("{0} {1} {2} {3}", num1, num2, num3, num4);

			Console.WriteLine("DoMatch = " + DoMath(num1));

			Console.ReadKey();
        }

		private static int DoMath(int number)
		{
			return number * 2;
		}
    }
}
