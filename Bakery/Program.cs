using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome! Here for the bread or the bread? (There also are pastries...)");
      Console.Write("How many loaves of Bread would you like to buy? Buy 2, get 1 free!!! ");
      int Quantity = int.Parse(Console.ReadLine());
      Bread bread = new Bread(Quantity);
      Pastry pastry = new Pastry(Quantity);
      Console.WriteLine($"Bread Price: ${bread.UnitCost} each");
      Console.WriteLine($"Pastry Price: ${pastry.UnitCost} each");
      bread.CalculateTotalCost();
      pastry.CalculateTotalCost();
      // Console.WriteLine($"Total Cost: ${bread.TotalCost}");
        Console.WriteLine($"Bread Total Cost: ${bread.TotalCost}");
        Console.WriteLine($"Bread Total Cost: ${pastry.TotalCost}");
    }
  }
}