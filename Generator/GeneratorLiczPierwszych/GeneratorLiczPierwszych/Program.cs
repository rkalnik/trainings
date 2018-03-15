using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorLiczPierwszych
{
    class Program
    {
        static void Main()
        {
            int n = 0;

            while (true)
            {
                Console.WriteLine("{0}", n);
                n++;
            }
            //bool gen(int n)
            //{
            //    if (n == 1)
            //    {
            //        return false;
            //    }
            //    else if (n == 2)
            //    {
            //        return true;
            //    }

            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}




            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
