﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	abstract class Employee
	{
		public Employee(string first, string last, string phone)
		{
			FirstName = first;
			LastName = last;
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }

		/// <summary>
		/// Abstract method declared in base class must be overridden by derived class methods
		/// </summary>
		//public abstract void RunPayroll();

		///// Virtual method declared in base class can be overridden by derived class methods
		public virtual void RunPayroll()
		{
			Console.WriteLine("Base class payroll method");
		}

	}
}