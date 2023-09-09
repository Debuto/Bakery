using System;

namespace Baker
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Here for the bread or the bread? (There also are pastries...)");

        Bread bread = new Bread();

        Console.WriteLine($"Bread Price: ${bread.PricePerLoaf} each");

          Console.Write("How many loaves of Bread would you like to buy? ");
          int breadQuantity = int.Parse(Console.ReadLine());

          double totalCost = CalculateTotalCost(bread, breadQuantity);

          Console.WriteLine($"Total Cost: ${totalCost}");
    }
    public static double CalculateTotalCost(Bread bread, int breadQuantity)
    {
        int freeBreadLoaves = breadQuantity / 3;

        double breadCost = (breadQuantity - freeBreadLoaves) * bread.PricePerLoaf;

        return breadCost;
    }
  }
  class Bread
  {
      public double PricePerLoaf { get; } = 2.0;
  }
}