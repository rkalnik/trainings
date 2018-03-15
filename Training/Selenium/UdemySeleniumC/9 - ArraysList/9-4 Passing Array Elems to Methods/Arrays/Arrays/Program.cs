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
            int[] myPreArray = { 5, 6, 9, 10};

            ModifyElement(myPreArray[1]);

            foreach(int num in myPreArray)
            {
                Console.WriteLine(num);
            }

			Console.ReadKey();
        }

        public static void ModifyElement(int arrayItem)
        {
            arrayItem *= 2;
            Console.WriteLine(arrayItem);
        }
    }
}
