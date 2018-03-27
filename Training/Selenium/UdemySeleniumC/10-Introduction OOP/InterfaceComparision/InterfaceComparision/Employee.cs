using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComparision
{
	class Employee
	{
		public Employee(string first, string last, string phone, decimal salary)
		{
			FirstName = first;
			LastName = last;
			Salary = salary;
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public decimal Salary { get; set; }

		public decimal GetPaymentAmount()
		{
			return Salary;
		}

		/// <summary>
		/// Abstract method declared in base class must be overridden by derived class methods
		/// </summary>
		//public abstract void RunPayroll();

		///// Virtual method declared in base class can be overridden by derived class methods
		//public virtual void RunPayroll()
		//{
		//	Console.WriteLine("Base class payroll method");
		//}

	}
}
