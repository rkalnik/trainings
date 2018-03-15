using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 100;

            switch(grade / 10)
            {
                case 9: //A
                case 10: //A
                    Console.WriteLine("You got an A");
                    break;
                case 8: //B
                    Console.WriteLine("You got a B");
                    break;
                case 7: //C
                    Console.WriteLine("You got a C");
                    break;
                case 6: //D
                    Console.WriteLine("You got a D");
                    break;
                default: //grade less than 60
                    Console.WriteLine("You got an F");
                    break;
            }

			Console.ReadKey();
        }
    }
}
