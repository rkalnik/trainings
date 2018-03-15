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
		/// Static class don't have instance of object, these methods call to stack and use values from stack
		/// </summary>

		public static int number;

        public static void Sum(int aNumber)
        {
            number += aNumber;
        }
    }
}
