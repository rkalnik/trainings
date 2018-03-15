using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    static class Helper
    {
		/// <summary>
		/// Good explenations: http://cezarywalenciuk.pl/blog/programing/post/kurs-podstawy-c-pisanie-metod-04
		/// </summary>

		public static int number;
        public static double dNumber;

        public static void Sum(int aNumber)
        {
            number += aNumber;
        }

        public static void Sum(double aNumber)
        {
            dNumber += aNumber;
        }

        public static void Sum(int aNumber = 3, double dNum = 5.5)
        {
            number += aNumber;
            dNumber += dNum;
        }
    }
}
