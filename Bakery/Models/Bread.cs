using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    public int UnitCost { get; set; }
    public double TotalCost { get; set; }

    public Bread(int quantity)
    {
      Quantity = quantity;
      UnitCost = 5;
    }

    public double CalculateTotalCost()
    {
      int freeBreadLoaves = Quantity / 3;
      double breadCost = (Quantity - freeBreadLoaves) * UnitCost;
      TotalCost = breadCost;
      return breadCost;
    }
  }
}
