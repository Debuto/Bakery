using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public int UnitCost { get; set; }
    public double TotalCost { get; set; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
      UnitCost = 2;
    }

    public double CalculateTotalCost()
    {
      int freePastryGood = Quantity / 4;
      double pastryCost = (Quantity - freePastryGood) * UnitCost;
      TotalCost = pastryCost;
      return pastryCost;
    }
  }
}
