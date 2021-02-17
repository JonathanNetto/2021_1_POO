using System;

class Cedulas {
  public static void Main (string[] args) {
    int valor = int.Parse(Console.ReadLine());
    int[] Notas = new int[7] {100, 50, 20, 10, 5, 2, 1};

    Console.WriteLine(valor);
    
    foreach (int nota in Notas) 
    {
      int qua_notas = valor/nota;
      Console.WriteLine($"{qua_notas} nota(s) de R$ {nota},00");
      valor -= qua_notas * nota; 
    }
  }
}