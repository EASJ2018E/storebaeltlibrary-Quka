using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoreBaeltBilletLibrary.Tests
{
	[TestClass]
	public class BilTest
	{
		[TestMethod]
		public void TestBilPriceWeekend()
		{
			// Arrange
			Bil b = new Bil();

			// Act
			b.Dato = new DateTime(2018, 9, 15); // Saturday
			decimal price = b.Pris();

			// Assert
			Assert.AreEqual(192, price);
		}

		[TestMethod]
		public void TestBilPriceWeekendBrobizz()
		{
			// Arrange
			Bil b = new Bil();

			// Act
			b.Brobizz = true;
			b.Dato = new DateTime(2018, 9, 15); // Saturday
			decimal price = b.Pris();

			// Assert
			Assert.AreEqual(182.4m, price);
		}

		[TestMethod]
		public void TestBilPriceNotWeekend()
		{
			// Arrange
			Bil b = new Bil();

			// Act
			b.Dato = new DateTime(2018, 9, 13); // Thursday
			decimal price = b.Pris();

			// Assert
			Assert.AreEqual(240, price);
		}
	}
}
