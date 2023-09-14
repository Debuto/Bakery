using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome! Here for the bread or the bread? (There also are pastries...)");
      Console.Write("Please choose what you would like to order! (bread/pastry/both): ");
      string choice = Console.ReadLine().ToLower();

      if (choice == "bread" || choice == "both")
      {
        Console.Write("How many loaves of Bread would you like to buy? Buy 2, get 1 free!!! ");
        int Quantity = int.Parse(Console.ReadLine());
        Bread bread = new Bread(Quantity);
        Console.WriteLine($"Bread Price: ${bread.UnitCost} each");
        bread.CalculateTotalCost();
        if (Quantity > 0)
          Console.WriteLine($"Bread Total Cost: ${bread.TotalCost}");
      }

      if (choice == "pastry" || choice == "both")
      {
        Console.Write("How many Pastries would you like to buy? Buy 3, get 1 free!!! ");
        int Quantity = int.Parse(Console.ReadLine());
        Pastry pastry = new Pastry(Quantity);
        Console.WriteLine($"Pastry Price: ${pastry.UnitCost} each");      
        pastry.CalculateTotalCost();
        if (Quantity > 0)
          Console.WriteLine($"Pastry Total Cost: ${pastry.TotalCost}");
      } 
    }
  }
}