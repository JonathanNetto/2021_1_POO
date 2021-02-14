using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o intervalo de tempo no formato \"HH:MM:SS\"");
    string [] hms = Console.ReadLine().Split(':');
    
    int horas = int.Parse(hms[0]);
    int minutos = int.Parse(hms[1]);
    int segundos = int.Parse(hms[2]);

    const int vel_luz = 300000;

    double segundos_totais = horas * 3600 + minutos * 60 + segundos;
    double dis_luz = segundos_totais * vel_luz;

    Console.WriteLine();

    Console.WriteLine($"A luz percorreu {dis_luz} km nesse intervalo");

  }
}