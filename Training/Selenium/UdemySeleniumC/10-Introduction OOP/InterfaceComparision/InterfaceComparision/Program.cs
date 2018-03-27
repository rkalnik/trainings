using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComparision
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee[] employeeList = new Employee[2];
			Invoice[] invoiceList = new Invoice[2];

			invoiceList[0] = new Invoice("2222", "Nails", 10, 9.99M);
			invoiceList[1] = new Invoice("1231", "Ladder", 2, 29.99M);
			employeeList[0] = new Employee("Jan", "Kowalski", "222-333-111", 45000M);
			employeeList[1] = new Employee("Ula", "Kowal", "434-354-122", 60000M);

			foreach (var currentPayable in invoiceList)
			{
				Console.WriteLine("Payment due: {0:C}", currentPayable.GetPaymentAmount());
			}

			foreach (var currentPayable in employeeList)
			{
				Console.WriteLine("Payment due: {0:C}", currentPayable.GetPaymentAmount());
			}

			Console.ReadKey();
		}
	}
}
