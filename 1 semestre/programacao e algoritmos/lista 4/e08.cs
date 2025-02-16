using System;

class Program {
  public static void Main (string[] args) {
    double n1, n2;
    Console.Write ("Escreva o primeiro número. ");
    n1 = double.Parse(Console.ReadLine());

    Console.Write ("Escreva o segundo número. ");
    n2 = double.Parse(Console.ReadLine());

    if (n1>n2){ Console.WriteLine("O maior é {0}.", n1); }
    else { Console.WriteLine("O maior é {0}.", n2); }
  }
}