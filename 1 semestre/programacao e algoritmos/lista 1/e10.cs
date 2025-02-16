using System;

class Program {
  public static void Main (string[] args) {
    int A, B, C;

    Console.WriteLine("Escreva o valor de A.");
    A = int.Parse(Console.ReadLine());

    Console.WriteLine("Escreva o valor de B.");
    B = int.Parse(Console.ReadLine());

    C = A;
    A = B;
    B = C;

    Console.WriteLine("A agora vale {0} e B agora vale {1}.",A,B);
  }
}