using System;

class SomaImpares {
  public static void Main (string[] args){
    int n = int.Parse(Console.ReadLine());

    for (int i = n; i > 0; i--)
    {
      int s = 0;
      int c = 0;

      string [] values = Console.ReadLine().Split(' ');
      int x = int.Parse(values[0]);
      int y = int.Parse(values[1]);

      while (c < y)
      {
        if (x % 2 == 0) 
          x ++;
        else 
        {
          s += x;
          x += 2;
          c += 1;
        }
      }
      Console.WriteLine(s);
      n --;
    }
    

  }
}