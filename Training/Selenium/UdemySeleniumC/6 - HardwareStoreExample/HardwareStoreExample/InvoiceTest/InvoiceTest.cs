﻿using System;
using HardwareStoreExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvoiceTest
{
	[TestClass]
	public class InvoiceTest	
	{
		[TestMethod]
		public void TestGetInvoiceAmount()
		{
			Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);

			Assert.AreEqual(31.90M, invoice1.GetInvoiceAmount());
		}

		[TestMethod]
		public void TestPartNumberProperty()
		{
			Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);

			Assert.AreEqual("1234", invoice1.PartNumber);
		}

		[TestMethod]
		public void TestPriceProperty()
		{
			Invoice invoice1 = new Invoice("1234", "Hammer", 2, -15.95M);

			Assert.AreEqual(0, invoice1.Price);
		}
	}
}
