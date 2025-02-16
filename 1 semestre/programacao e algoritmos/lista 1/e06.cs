using System;

class Program {
  public static void Main (string[] args) {
    int aa, an, i;
    
    Console.WriteLine("Escreva o ano atual.");
    aa = int.Parse(Console.ReadLine());

    Console.WriteLine("Escreva o ano de nascimento.");
    an = int.Parse(Console.ReadLine());

    i = aa-an;
    
    Console.WriteLine("Você tem "+i+" anos.");
  }
}