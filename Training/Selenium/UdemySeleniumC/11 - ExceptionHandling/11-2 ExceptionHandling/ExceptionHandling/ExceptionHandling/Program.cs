using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 5;
            int denominator = 0;

            try
            {
                int result = numerator / denominator;
                Console.WriteLine(result);
				Console.ReadKey();
            }
            catch(Exception)
            {
                Console.WriteLine("An exception occured try again later");
				Console.ReadKey();
            }
            
        }
    }
}
