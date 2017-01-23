using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideInherit
{
	class JewelThief : Locksmith
	{
		private Jewels stolenJewels = null;
		//jesli uzyjemy slowa kluczowego new zamiast override to spowodujemy ze metoda ReturnContents z klasy pochodnej JewelThief zostanie ukryta
		//natomiast jesli uzyjemy override to metoda ReturnContents w klasie bazowej zostanie przeslonieta (nadpisana) nowa implementacja z klasy pochodnej JewelThief
		override public void ReturnContents(Jewels safeContents, Owner owner)
		{
			stolenJewels = safeContents;
			Console.WriteLine("Kradnę zawartość sejfu! " + stolenJewels.Sparkle());
		}
	}
}
