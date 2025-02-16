using System;

class Program {
  public static void Main (string[] args) {
    Console.Write ("Digite um número. ");
    Console.WriteLine ("O número é {0}.", double.Parse(Console.ReadLine())%2==0 ? "par" : "ímpar");
  }
}