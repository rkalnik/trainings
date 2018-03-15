using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "July Quarterly Report";
            string date = "July";
            string type = "Quarterly";

            Report myReport = new Report(name, date, type);
            myReport.ReportType();
            Console.WriteLine(myReport.CreateReport());
            myReport.ReportCount(5);
			Console.ReadKey();


        }
    }

}
