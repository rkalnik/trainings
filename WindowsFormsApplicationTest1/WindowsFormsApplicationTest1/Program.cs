using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationTest1
{
	class Foo
	{
		public string About = "Klasa v.1.0";
	}
	
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			
			Foo MyFoo = new Foo();
			Console.Write(MyFoo.About);
			Console.Read();
		}
	}
}
