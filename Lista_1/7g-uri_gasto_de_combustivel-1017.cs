using System;

class Gasto {
  public static void Main (string[] args) {
    int t_gasto = int.Parse(Console.ReadLine());
    int vel_media = int.Parse(Console.ReadLine());
    const double media_consumo = 12.0;

    double litros = t_gasto * vel_media / media_consumo;
    
    Console.WriteLine($"{litros:f3}");
  }
}