using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			//employee1
			string firstName = "John";
			string lastName = "Smith";
			string phone = "555-667-2344";
			decimal salary = 5000m;
			int vacationDays = 10;

			FullTime newEmpl = new FullTime(firstName, lastName, phone, salary, vacationDays);

			Console.WriteLine(newEmpl.VacationDays);

			//Abstract class - can not create instance of the object
			//Employee newEmployee = new Employee(firstName, lastName, phone);

			//employee2
			string firstName2 = "Sara";
			string lastName2 = "Jones";
			string phone2 = "111-232-5466";
			decimal rate = 15.00m;

			PartTime newPT = new PartTime(firstName2, lastName2, phone2, rate);

			List<Employee> lists = new List<Employee>();
			lists.Add(newEmpl);
			lists.Add(newPT);
			
			foreach (Employee emp in lists)
			{
				Console.WriteLine(emp.ToString());
				emp.RunPayroll();
			}

			Console.ReadKey();
		}
	}
}
