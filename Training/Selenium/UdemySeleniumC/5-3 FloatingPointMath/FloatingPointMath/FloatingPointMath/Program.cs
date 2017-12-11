using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingPointMath
{
    class Program
    {
        static void Main(string[] args)
        {
            float aFloatingValue = 0.5F;
            double aDoubleValue = 0.5;
            decimal aDecimalValue = 0.5M;
            int aIntValue = 5;

            double aDoubleSum = aFloatingValue + aDoubleValue;

            double aDoubleSum2 = aDoubleValue + aIntValue;

            double aDoubleSum3 = aFloatingValue + aIntValue;

            float aFloatSum = aFloatingValue + aIntValue;

            float aFloatSum2 = aFloatingValue + aDoubleValue;

            decimal aDecimalSum = aDecimalValue + aIntValue;

            decimal aDecimalSum2 = aFloatingValue + aDoubleValue;

            decimal aDecimalSum3 = aFloatingValue + aDecimalValue;
        }
    }
}
