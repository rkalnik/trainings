using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerMath
{
    class Program
    {
        static void Main(string[] args)
        {
            //addition
            int sum = 7 + 4;

            //subtraction
            int difference = 7 - 4;

            //multiplication
            int product = 7 * 4;

            //division 
            int quotient = 7 / 4;

            //modulus (remainder)
            int remainder = 7 % 4;

            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);

            Console.ReadKey();
        }
    }
}
