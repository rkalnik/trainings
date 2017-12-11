using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 15.30m;

            string output = String.Format("The current price is {0:C} per ounce", price);
			
			Console.WriteLine(output);

        }
    }
}
