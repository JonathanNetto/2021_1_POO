using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a base a altura do retângulo");
    double b = int.Parse(Console.ReadLine());
    double h = int.Parse(Console.ReadLine());

    Console.WriteLine();

    double area = b*h;
    double perimetro = b*2 + h*2;
    double diagonal = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
    
    Console.WriteLine($"Área = {area:f2} - Perímetro = {perimetro:f2} - Diagonal = {diagonal:f2}");
  }
}