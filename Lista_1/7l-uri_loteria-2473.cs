using System;

class Loteria {
  public static void Main (string[] args) {
    string [] aposta = Console.ReadLine().Split(' ');
    string [] sorteio = Console.ReadLine().Split(' ');
    int a1 = int.Parse(aposta[0]);
    int b1 = int.Parse(aposta[1]);
    int c1 = int.Parse(aposta[2]);
    int d1 = int.Parse(aposta[3]);
    int e1 = int.Parse(aposta[4]);
    int f1 = int.Parse(aposta[5]);

    int a2 = int.Parse(sorteio[0]);
    int b2 = int.Parse(sorteio[1]);
    int c2 = int.Parse(sorteio[2]);
    int d2 = int.Parse(sorteio[3]);
    int e2 = int.Parse(sorteio[4]);
    int f2 = int.Parse(sorteio[5]);

    int contador = 0;


    int[] Aposta = new int[6] {a1, b1, c1, d1, e1, f1};
    int[] Sorteio = new int[6] {a2, b2, c2, d2, e2, f2};

    for (int i = 0; i<6; i++)
      for (int j = 0; j<6; j++)
        if (Aposta[i] == Sorteio [j])
        {
          contador += 1;
        }
        
    if (contador == 3) Console.WriteLine("terno");
    else if (contador == 4) Console.WriteLine("quadra");
    else if (contador == 5) Console.WriteLine("quina");
    else if (contador == 6) Console.WriteLine("sena");
    else Console.WriteLine("azar");
  }
}