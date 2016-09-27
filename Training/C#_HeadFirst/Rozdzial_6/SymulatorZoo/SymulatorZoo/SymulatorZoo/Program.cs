using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulatorZoo
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal animal = new Animal();

			Lion lion = new Lion();
			//lion.

			Hippo hippo = new Hippo();
			//hippo.

			Dog spot = new Dog();
			spot.MakeNoise();
			spot.Roam();
			spot.Eat();
			spot.Sleep();
			spot.Fetch();

			
		}
	}
}
