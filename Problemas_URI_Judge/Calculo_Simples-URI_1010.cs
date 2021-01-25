using System;

class MainClass {
  public static void Main (string[] args) {
    string [] a = Console.ReadLine().Split(' ');
    string [] b = Console.ReadLine().Split(' ');
    int c1 = int.Parse(a[0]);
    int n1 = int.Parse(a[1]);
    double v1 = double.Parse(a[2]);
    int c2 = int.Parse(b[0]);
    int n2 = int.Parse(b[1]);
    double v2 = double.Parse(b[2]);
    double vp = n1 * v1 + n2 * v2;
    Console.WriteLine($"VALOR A PAGAR: R$ {vp:0.00}");
  }
}