using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideInherit
{
	class Program
	{
		static void Main(string[] args)
		{
			Owner owner = new Owner();
			Safe safe = new Safe();
			JewelThief jewelThief = new JewelThief();
			jewelThief.OpenSafe(safe, owner);

			//Locksmith calledAsLocksmith = new JewelThief();
			//calledAsLocksmith.ReturnContents(safeContents, owner);

			//JewelThief calledAsJewelThief = new JewelThief();
			//calledAsJewelThief.ReturnContents(safeContents, owner);

			Console.ReadKey();

		}
	}
}
