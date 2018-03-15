using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Report
    {
		private string name;
		private string date;
        public Report(string name, string date, string type)
        {
            Name = name;
            Date = date;
            Type = type;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                if(value == "July")
                {
                    date = value;
                }
            }
        }

        public string Type
        {
            get;
            set;
        }

        public void ReportType()
        {
            Console.WriteLine("This is a {0} report", Type);
        }

        public string CreateReport()
        {
            return string.Format("I am creating the {0} report", Name);
        }

        public void ReportCount(int number)
        {
            Console.WriteLine("There are {0} lines in the report", number);
        }


    }
}
