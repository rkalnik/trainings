using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop
            int count = 1;
            while(count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }

            //do while loop
            int counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= 10);

			Console.ReadKey();
        }
    }
}
