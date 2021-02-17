using System;

class Intervalo {
  public static void Main (string[] args) {
    double v = double.Parse(Console.ReadLine());

      if (0 <= v && v <= 25)
      {
        Console.WriteLine("Intervalo [0,25]");
      }

      else if (25 < v && v <= 50)
      {
        Console.WriteLine("Intervalo (25,50]");
      }

      else if (50 < v && v <= 75)
      {
        Console.WriteLine("Intervalo (50,75]");
      }

      else if (75 < v && v <= 100)
      {
        Console.WriteLine("Intervalo (75,100]");
      }
      
      else
      {
        Console.WriteLine("Fora de intervalo");
      }
  }
}