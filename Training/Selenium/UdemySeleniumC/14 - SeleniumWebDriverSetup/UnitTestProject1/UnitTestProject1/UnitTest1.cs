using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var driver = GetChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("https://www.surveygizmo.com/s3/4480331/QAT-2021-All-China-Research-Team-in-partnership-with-Caixin-latest?sguid=oOdFbAhQyVKTGBA00uzIwXmbLvA1test20&passcode=oOdFbAhQyVKTGBA00uzIwXmbLvA1&email=vyung@jefferies.com&firstname=Victoria&lastName=Yung");
			driver.Close();
		}

		private IWebDriver GetChromeDriver()
		{
			var outPutDircetory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			return new ChromeDriver(outPutDircetory);
		}
	}
}
