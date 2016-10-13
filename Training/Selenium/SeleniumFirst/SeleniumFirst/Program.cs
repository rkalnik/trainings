using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace SeleniumFirst
{
	
	class Program : PropertiesCollection
	{

		////Create reference for our browser
		//IWebDriver driver = new ChromeDriver();

		static void Main(string[] args)
		{
			
		}


		

		[SetUp]
		public void Initilize()
		{
			//FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
			//service.FirefoxBinaryPath = @"c:\Program Files (x86)\Mozilla Firefox\firefox.exe";
			//driver = new FirefoxDriver(service);
			//driver.Manage().Window.Maximize();
			//FirefoxBinary binary = new FirefoxBinary(@"c:\Program Files (x86)\Mozilla Firefox\firefox.exe");
			//FirefoxProfile profile = new FirefoxProfile();
			//driver = new FirefoxDriver(binary, profile);
			driver = new ChromeDriver();

			//Navigate to page
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl(Configuration.Url);
			Console.WriteLine("Open browser");
		}

		[Test]
		public void ExecuteTest()
		{
			//Login to application

			LoginPageObject pageLogin = new LoginPageObject();
			EAPageObject pageEA =  pageLogin.Login("execute", "automation");
			Thread.Sleep(3000);
			pageEA.FillUserForm("KK", "Ziutek", "Automation");
			Thread.Sleep(5000);

			//Initialize the page by calling its reference
			//EAPageObject page = new EAPageObject();

			//pageEA.txtInitial.SendKeys("test automation");
			//Thread.Sleep(5000);

			//pageEA.btnSave.Click();


			////Title
			//SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", PropertyType.Id);

			////Initial - Enter value to initial textbox field
			//SeleniumSetMethods.EnterText("Initial", "test value", PropertyType.Name);

			//Console.WriteLine("The Value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

			//Console.WriteLine("The Value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
			//Thread.Sleep(5000);
			////Click button
			//SeleniumSetMethods.Click("Save", PropertyType.Name);

			////EnterText(element, value, type)


			////Find the element textbox in google and enter test value
			//IWebElement element = driver.FindElement(By.Name("q"));
			////Perform Ops
			//element.SendKeys("execute automation");
			//Thread.Sleep(10000);
			//Console.WriteLine("Execute tests");
		}

		[Test]
		public void NextTest()
		{
			Console.WriteLine("Test output");
		}

		[TearDown]
		public void CleanUp()
		{
			driver.Close();
			Console.WriteLine("Closed the browser");
		}


	}
}
