using System;

class Program {
  public static void Main (string[] args) {
    Console.Write ("Escreva um número. ");
    Console.WriteLine("{0:F0}", double.Parse(Console.ReadLine()));
  }
}