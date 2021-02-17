using System;

class Ordenacao {
  public static void Main (string[] args) {
    string [] valores = Console.ReadLine().Split(' ');
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);
    int c = int.Parse(valores[2]);

    if (a < b && a < c)
    {
      Console.WriteLine(a);
      if (b < c) 
      {
        Console.WriteLine(b);
        Console.WriteLine(c);
      }  
      else 
      {
        Console.WriteLine(c);
        Console.WriteLine(b);
      }
    }
    else if (b < a && b < c)
    {
      Console.WriteLine(b);
      if (a < c)
      {
        Console.WriteLine(a);
        Console.WriteLine(c);
      }
      else
      {
        Console.WriteLine(c);
        Console.WriteLine(a);
      }
    }
    else
    {
      Console.WriteLine(c);
      if (a < b)
      {
        Console.WriteLine(a);
        Console.WriteLine(b);
      }
      else
      {
        Console.WriteLine(b);
        Console.WriteLine(a);
      }
    }

    Console.WriteLine();

    Console.WriteLine($"{a}\n{b}\n{c}");
  }
}
