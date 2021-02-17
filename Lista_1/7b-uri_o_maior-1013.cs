using System;

class Maior {
  public static void Main (string[] args) { 
    string [] vet = Console.ReadLine().Split(' ');
    int a = int.Parse(vet[0]);
    int b = int.Parse(vet[1]);
    int c = int.Parse(vet[2]);

    int maior_ab = (a + b + Math.Abs(a - b)) / 2;
    int maior = (maior_ab + c + Math.Abs(maior_ab - c)) / 2;

    Console.WriteLine($"{maior} eh o maior");
  }
}