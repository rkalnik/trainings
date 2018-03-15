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

            ModifyArray(myPreArray);

            foreach(int num in myPreArray)
            {
                Console.WriteLine(num);
            }

			Console.ReadKey();

        }

        public static void ModifyArray(int[] array)
        {
            for(int counter = 0; counter < array.Length; counter++)
            {
                array[counter] *= 2;
            }
        }
    }
}
