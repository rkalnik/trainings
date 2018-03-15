using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassExample
{
    static class Helper
    {
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
    }
}
