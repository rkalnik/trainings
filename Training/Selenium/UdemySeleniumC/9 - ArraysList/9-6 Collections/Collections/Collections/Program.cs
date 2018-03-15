using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();

            items.Add("Widgets");
            items.Add("Doodles");
            items.Add("Thingys");
			items.Add("Test new item");
			items.Reverse();
			

            foreach(string item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("There are {0} items in the list", items.Count);

            items.Remove("Widgets");

            Console.WriteLine("There are {0} items in the list", items.Count);

			Console.WriteLine(items.FirstOrDefault());

			Console.ReadKey();
        }
    }
}
