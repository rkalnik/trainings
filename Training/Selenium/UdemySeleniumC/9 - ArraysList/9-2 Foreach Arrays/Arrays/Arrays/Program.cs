using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
			//Declaring and creating arrays
            int[] myArray = new int[10];

            myArray[5] = 10;

            int[] myPreArray = { 5, 6, 9, 10};

            int total = 0;
			foreach (int number in myPreArray)
			{
				total += number;
			}

            Console.WriteLine(total);
        }
    }
}
