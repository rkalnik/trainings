using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakandContinue
{
    class Program
    {
        static void Main(string[] args)
        {
			////break statement
			for (int count = 1; count <= 10; count++)
			{
				if (count == 5)
				{
					break;
				}
				Console.WriteLine(count);
			}

			//Console.WriteLine(" ");
   //         //continue statement
   //         for (int count = 1; count <= 10; count++)
   //         {
   //             if (count == 5)
   //             {
   //                 continue;
   //             }
   //             Console.WriteLine(count);
   //         }
			Console.ReadKey();
        }
    }
}
