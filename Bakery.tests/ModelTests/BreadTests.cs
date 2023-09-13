using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateAnInstanceOfBread_Bread()
    {
      // Arrange
      Bread newBread = new Bread(1);
      // Assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

// 1 test without discount
    [TestMethod]
    public void CalculateTotalCost_DeterminePriceWithoutDiscount_Double()
    {
      // Arrange
      Bread newBread = new Bread(2);
      double testCost = 10;
      // Act
      double testTotalPrice = newBread.CalculateTotalCost();
      // Assert
      Assert.AreEqual(testCost, testTotalPrice);
    }

// 1 test with dicount
    [TestMethod]
    public void CalculateTotalCost_DeterminePriceWithDiscount_Double()
    {
      // Arrange
      Bread newBread = new Bread(3);
      double testCost = 10;
      // Act
      double testTotalPrice = newBread.CalculateTotalCost();
      // Assert
      Assert.AreEqual(testCost, testTotalPrice);
    }
  }
}