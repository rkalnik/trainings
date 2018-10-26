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
            int result = 0;

            try
            {
                if(denominator == 0)
                {
                    throw new DivideByZeroException("You cannot divide by zero");
                }
                result = numerator / denominator;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("An exception occured");
            }
            finally
            {
                Console.WriteLine(result);
				Console.ReadKey();
            }
            
        }
    }
}
