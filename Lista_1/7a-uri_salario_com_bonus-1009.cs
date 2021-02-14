using System;

class MainClass {
  public static void Main (string[] args) {
    string nome = Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());
    double total = salario + (0.15 * vendas);
    Console.WriteLine($"TOTAL = R$ {total:f2}");
  }
}