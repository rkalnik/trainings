using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace ReadingHtmlTables
{
	class Program : Base
	{

		static void Main(string[] args)
		{
			Initilize();
			TablePage page = new TablePage();

			//Read table
			Utilities.ReadTable(page.table);
			Console.WriteLine("********************");
			//Get the cell value from the table
			//Console.WriteLine(Utilities.ReadCell("First name", 2));
			Console.WriteLine("The first name: {0} and surname: {1}, date brith {2}", Utilities.ReadCell("First name", 1), Utilities.ReadCell("Surname", 1), Utilities.ReadCell("Date of birth", 1));
			Console.WriteLine("********************");
			Console.ReadKey();
		}

		[SetUp]
		public static void Initilize()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("http://codepen.io/jordyvanraaij/full/jlAqp/");
		}

		[Test]
		public void GetHtmlTable()
		{
			//TablePage page = new TablePage();

			////Read table
			//Utilities.ReadTable(page.table);

			////Get the cell value from the table
			//Utilities.ReadCell("First name", 2);



		}

		[TearDown]

		public void Close()
		{
			driver.Quit();
		}
	}
}
