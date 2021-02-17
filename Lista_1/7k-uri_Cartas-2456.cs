using System;

class Sequencia {
  public static void Main (string[] args) {
    string [] cartas = Console.ReadLine().Split(' ');
    int a = int.Parse(cartas[0]);
    int b = int.Parse(cartas[1]);
    int c = int.Parse(cartas[2]);
    int d = int.Parse(cartas[3]);
    int e = int.Parse(cartas[4]);

    if (a<b && b<c && c<d && d<e) Console.WriteLine("C");
    else if (a>b && b>c && c>d && d>e) Console.WriteLine("D");
    else Console.WriteLine("N");
  }
}    