using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("How much would you like to convert?");

      string amount = Console.ReadLine();

      double toConvert = Convert.ToDouble(amount);

      Console.WriteLine($"{amount} equals to...");

      int goldValue = 10;

      int silverValue = 5;

      double goldCoins = Math.Floor(toConvert / goldValue);

      double leftOverGold = toConvert % goldValue;

      Console.WriteLine($"{goldCoins} gold coins with a leftover of {leftOverGold}");

      double silverCoins = Math.Floor(leftOverGold / silverValue);

      double leftOverSilver = leftOverGold % silverValue;

      Console.WriteLine($"The amount of silver coins is {silverCoins} with a leftover of {leftOverSilver} bronze coins");

      


    }
  }
}
