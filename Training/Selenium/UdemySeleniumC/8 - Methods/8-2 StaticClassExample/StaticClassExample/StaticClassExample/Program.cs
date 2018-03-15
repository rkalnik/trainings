using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
			//Helper myClass = new Helper();

            Helper.Sum(10);
            Console.WriteLine(Helper.number);

            Helper.Sum(10);
            Console.WriteLine(Helper.number);
        }
    }
}
