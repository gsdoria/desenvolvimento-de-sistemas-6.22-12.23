using System;

class Program {
  public static void Main (string[] args) {
    double n1;
    Console.Write ("Escreva o primeiro número. ");
    n1 = double.Parse(Console.ReadLine());
    Console.Write ("Escreva o segundo número. ");

    Console.WriteLine("O produto é igual a {0}.", n1*double.Parse(Console.ReadLine()));
  }
}