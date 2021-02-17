using System;

class Consumo {
  public static void Main (string[] args) {
  int distancia = int.Parse(Console.ReadLine());
  double combustivel = double.Parse(Console.ReadLine());

  double km_l = distancia / combustivel;

  Console.WriteLine($"{km_l:f3} km/l");
  }
}
