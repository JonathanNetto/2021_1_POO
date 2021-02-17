using System;

class Area {
  public static void Main (string[] args) {
    string [] abc = Console.ReadLine().Split(' ');
    double a = double.Parse(abc[0]);
    double b = double.Parse(abc[1]);
    double c = double.Parse(abc[2]);
    const double pi = 3.14159; 

    double triangulo = a * c / 2;
    double circulo = pi * Math.Pow(c, 2);
    double trapezio = (a + b) * c / 2;
    double quadrado = b * b;
    double retangulo = a * b;

    Console.WriteLine($"TRIANGULO: {triangulo:f3}");
    Console.WriteLine($"CIRCULO: {circulo:f3}");
    Console.WriteLine($"TRAPEZIO: {trapezio:f3}");
    Console.WriteLine($"QUADRADO: {quadrado:f3}");
    Console.WriteLine($"RETANGULO: {retangulo:f3}");
  }
}
