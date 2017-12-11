using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestApp.MathOperations.Double(10);
        }

		[TestMethod]
		public void TestMethod2()
		{
			Assert.AreEqual(25, TestApp.MathOperations.Double(10));
		}
	}
}
