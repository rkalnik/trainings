using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop 
            int count = 1;
            while (count <= 10)
            {
                Console.Write(count);
                count++;
            }

            //for loop
            for(int counter = 1; counter <= 10; counter++)
            {
                Console.Write(counter);
            }

			Console.ReadKey();
        }
    }
}
