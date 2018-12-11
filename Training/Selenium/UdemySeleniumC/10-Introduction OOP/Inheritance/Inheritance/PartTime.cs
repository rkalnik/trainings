using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class PartTime : Employee
	{

		public PartTime(string first, string last, string phone, decimal rate) : base(first, last, phone)
		{
			HourlyRate = rate;
		}
		public decimal HourlyRate { get; set; }

		public override string ToString()
		{
			return FirstName + " " + LastName + " is part time";
		}

		public override void RunPayroll()
		{
			Console.WriteLine("This employee's salary is {0:c} hour", HourlyRate);
		}
	}
}
