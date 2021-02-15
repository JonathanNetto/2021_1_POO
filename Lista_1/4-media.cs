using System;

class Media {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int nota_1 = int.Parse(Console.ReadLine());

    Console.WriteLine();

    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    int nota_2 = int.Parse(Console.ReadLine());
    
    int media_parcial = ((nota_1 * 2) + (nota_2 * 3))/5;

    Console.WriteLine();
    
    Console.WriteLine($"Média parcial = {media_parcial}"); 

  }
}