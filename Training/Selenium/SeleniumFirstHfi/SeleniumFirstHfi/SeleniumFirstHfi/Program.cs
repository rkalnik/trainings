using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirstHfi
{
	class Program : WebConfiguration
	{
		static void Main(string[] args)
		{
		}

		[SetUp]
		public void Initialize()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl(WebConfiguration.Url);
			Console.WriteLine("Open browser");
		}

		[Test]

		public void ClickLoginButton()
		{
			HomePage hp = new HomePage();
			Thread.Sleep(5000);
			hp.CloseWelcomeMessage();
			hp.NavigateToLoginPage();
			//Assert.IsTrue();
		}



		[TearDown]
		public void CleanUp()
		{
			driver.Close();
			Console.WriteLine("Close browser");
		}

	}
}
