using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace Exercises1
{
	[TestClass]
	public class UnitTest1
	{
		//private IWebDriver GetChromeDriver()
		//{
		//	var outPutDircetory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		//	return new ChromeDriver(outPutDircetory);
		//}

		static IWebDriver driver;
		private IWebElement element;
		private By locator;


		[TestInitialize]
		public void TestSetup()
		{
			var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			driver = new ChromeDriver(outPutDirectory);
		}

		[TestMethod]
		[TestCategory("Locators")]
		public void ClickLocatedElement()
		{
			driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
			driver.Manage().Window.Maximize();
			//driver.Navigate().Back();
			var link = driver.FindElements(By.ClassName("et_pb_blurb_description"))[4];

			//click any radio button, hint:  FindElement().Click();
			driver.FindElement(By.XPath("//input[@type='radio'][@value='male']")).Click();

			//select one checkbox
			driver.FindElement(By.XPath("//input[@type='checkbox'][@value='Bike']")).Click();

			//select Audi from the dropdown
			//driver.FindElement(By.XPath("//select/option[@value='audi']")).Click();

			driver.FindElement(By.TagName("select")).Click();
			driver.FindElement(By.XPath("//*[@value='audi']")).Click();

			//open Tab2 and assert that it is opened. Hint, use .Text property when you find the element
			driver.FindElement(By.XPath("//*[@class='et_pb_tab_1']/a[text()='Tab 2']")).Click();
			Assert.AreEqual("Tab 2 content", driver.FindElement(By.XPath("//*[@class='et_pb_tab_content'][text()=' Tab 2 content']")).Text);
			//in the HTML Table with id, highlight one of the salary cells
			driver.FindElement(By.XPath("//*[@id='htmlTableId']//tr[2]/td[3]"));
			
			//driver.FindElement(By.Id("simpleElementsLink"));
			//driver.FindElement(By.CssSelector("#simpleElementsLink"));
			//driver.FindElement(By.LinkText("Click this link"));
			//driver.FindElement(By.Name("clickableLink"));
			//driver.FindElement(By.XPath("//*[@id='simpleElementsLink']")).Click();
			//driver.FindElement(By.XPath("//*[contains(@class, 'et_pb_blurb_description')]")).Click();
			//driver.FindElement(By.TagName("a")).Click();

		}

		[TestMethod]
		[TestCategory("Navigation")]
		public void NavigationTest()
		{
			//Go here and assert for title - "https://www.ultimateqa.com"
			driver.Navigate().GoToUrl("https://www.ultimateqa.com");
			//Assert.AreEqual("Home - Ultimate QA", driver.FindElement(By.XPath("//title[text()='Home - Ultimate QA']")).Text);
			Assert.AreEqual("Home - Ultimate QA", driver.Title);
			//Go here and assert for title - "https://www.ultimateqa.com/automation"
			driver.Navigate().GoToUrl("https://www.ultimateqa.com/automation");
			Assert.AreEqual("Automation Practice - Ultimate QA", driver.Title);
			//Click link with href - /complicated-page
			driver.FindElement(By.XPath("//*[@href='/complicated-page']")).Click();
			//assert page title 'Complicated Page - Ultimate QA'
			Assert.AreEqual("Complicated Page - Ultimate QA", driver.Title);
			//Go back
			driver.Navigate().Back();
			//assert page title equals - 'Automation Practice - Ultimate QA'

		}

		[TestMethod]
		[TestCategory("Manipulation")]
		public void Manipulation()
		{
			driver.Navigate().GoToUrl("https://www.ultimateqa.com/filling-out-forms/");
			//find the name field
			var nameField = driver.FindElements(By.Id("et_pb_contact_name_1"));

			//clear the field
			//nameField.Clear();
			//type into the field
			nameField[1].SendKeys("test");
			//nameField.SendKeys("Test name");
			
			//find the text field
			var messageField = driver.FindElement(By.Id("et_pb_contact_message_1"));
			//clear the field
			messageField.Clear();
			//type into the field
			messageField.SendKeys("Test message");
			//submit
			var submitButton = driver.FindElements(By.ClassName("et_contact_bottom_container"));
			submitButton[0].Click();
		}

		[TestMethod]
		[TestCategory("Element Interrogation")]
		public void ElementInterrogationTest()
		{
			driver.Url = "https://www.ultimateqa.com/simple-html-elements-for-automation/";
			driver.Manage().Window.Maximize();
			//1. find button by Id
			var myElement = driver.FindElement(By.Id("button1"));
			//2. GetAttribute("type") and assert that it equals the right value
			var getAttribute = myElement.GetAttribute("type");
			Assert.AreEqual("submit", getAttribute);
			//3. GetCssValue("letter-spacing") and assert that it equals the correct value
			var getCssValue = myElement.GetCssValue("letter-spacing");
			Assert.AreEqual("normal", getCssValue);
			//4. Assert that it's Displayed
			Assert.IsTrue(myElement.Displayed);
			//5. Assert that it's Enabled
			Assert.IsTrue(myElement.Enabled);
			//6. Assert that it's NOT selected
			Assert.IsFalse(myElement.Selected);
			//7. Assert that the Text is correct
			Assert.AreEqual("Click Me!", myElement.Text);
			//8. Assert that the TagName is correct
			Assert.AreEqual("button", myElement.TagName);
			//9. Assert that the size height is 21
			Assert.AreEqual("21", myElement.Size.Height);
			//10. Assert that the location is x=190, y=330
			//Should failed because it's depend on size browser so should be other than expected
			Assert.AreEqual("190", myElement.Location.X);
			Assert.AreEqual("336", myElement.Location.Y);
		}


		[TestCleanup]

		public void TestCleanup()
		{
			driver.Close();
			driver.Quit();
			
		}


		}
	}
