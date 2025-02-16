using System;

class Program {
  public static void Main (string[] args) {
    double va, vb;

    Console.Write ("Escreva o valor da 1ª variável. ");
    va = double.Parse(Console.ReadLine());

    Console.Write ("Escreva o valor da 2ª variável. ");
    vb = double.Parse(Console.ReadLine());

    va += vb; vb = va - vb; va -= vb;

    Console.Write("O valor de 1ª variável agora é {0} e da 2ª {1}.", va, vb);
  }
}