using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 85;
            string course = "Math";

            if(course == "Math" && grade > 80)
            {
                Console.WriteLine("Great math student");
            }

            if(course == "Science" && grade > 80)
            {
                Console.WriteLine("Great science student");
            }

            if (course == "Math" || grade > 80)
            {
                Console.WriteLine("Great math student");
            }

            if (course == "Science" || grade > 80)
            {
                Console.WriteLine("Great science student");
            }

            string studentType = "honors";

            if((course == "Science") || (grade > 80 && studentType == "honors"))
            {
                Console.WriteLine("Great science student");
            }
			Console.ReadKey();
        }
    }
}
