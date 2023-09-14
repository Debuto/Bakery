using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateAnInstanceOfPastry_Pastry()
    {
      // Arrange
      Pastry newPastry = new Pastry(1);
      // Assert
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

// 1 test without discount
    [TestMethod]
    public void CalculateTotalCost_DeterminePriceWithoutDiscount_Double()
    {
      // Arrange
      Pastry newPastry = new Pastry(3);
      double testCost = 6;
      // Act
      double testTotalPrice = newPastry.CalculateTotalCost();
      // Assert
      Assert.AreEqual(testCost, testTotalPrice);
    }

// 1 test with dicount
    [TestMethod]
    public void CalculateTotalCost_DeterminePriceWithDiscount_Double()
    {
      // Arrange
      Pastry newPastry = new Pastry(4);;
      double testCost = 6;
      // Act
      double testTotalPrice = newPastry.CalculateTotalCost();
      // Assert
      Assert.AreEqual(testCost, testTotalPrice);
    }
  }
}