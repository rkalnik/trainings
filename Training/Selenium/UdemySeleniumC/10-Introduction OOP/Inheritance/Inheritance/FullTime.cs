using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class FullTime : Employee
	{
		public FullTime(string first, string last, string phone, decimal salary, int vacation) : base(first, last, phone)
		{
			SalaryRate = salary;
			VacationDays = vacation;
		}
		public decimal SalaryRate { get; set; }
		public decimal VacationDays { get; set; }

		public override string ToString()
		{
			return FirstName + " " + LastName + " is full time";
		}

		//public override void RunPayroll()
		//{
		//	Console.WriteLine("This employee's salary is {0:c}", SalaryRate);
		//}
	}
}
