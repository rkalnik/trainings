using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	class Program
	{
		static void Main(string[] args)
		{
			IPayable[] payableObjects = new IPayable[4];

			payableObjects[0] = new Invoice("2222", "Nails", 10, 9.99M);
			payableObjects[1] = new Invoice("1231", "Ladder", 2, 29.99M);
			payableObjects[2] = new Employee("Jan", "Kowalski", "222-333-111", 45000M);
			payableObjects[3] = new Employee("Ula", "Kowal", "434-354-122", 60000M);

			foreach(var currentPayable in payableObjects)
			{
				Console.WriteLine("Payment due: {0:C}", currentPayable.GetPaymentAmount());
			}

			Console.ReadKey();
		}
	}
}
