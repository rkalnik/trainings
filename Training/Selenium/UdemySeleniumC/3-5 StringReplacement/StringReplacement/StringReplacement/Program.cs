using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSandwiches = 6;
            int costOfSandwiches = 3;

			//Console.WriteLine("The {0} sandwitches cost {1} dollars", numberOfSandwiches, costOfSandwiches);
			Console.WriteLine("The {0} sandwiches cost {1:C} dollars", numberOfSandwiches, costOfSandwiches );
			Console.ReadKey();

        }
    }
}
