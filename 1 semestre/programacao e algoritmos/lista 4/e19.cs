using System;

class Program {
  public static void Main (string[] args) {
    int m, n;
    
    Console.Write ("Escreva o 1º número. "); m = int.Parse(Console.ReadLine());

    Console.Write ("Escreva o 2º número. "); n = int.Parse(Console.ReadLine());

    n += m;

    Console.WriteLine ("O caracter obtido a partir da soma foi {0}", Char.ConvertFromUtf32(n));
  }
}