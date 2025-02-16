using System;

class Program {
  public static void Main (string[] args) {
    int i=0;
    Console.Write ("Escreva seu nome. "); Console.ReadLine();
    
    Console.Write ("Digite sua idade. ");
    i += int.Parse(Console.ReadLine());

    Console.Write ("\nEscreva seu nome. "); Console.ReadLine();
    
    Console.Write ("Digite sua idade. ");
    i += int.Parse(Console.ReadLine());

    Console.WriteLine("A soma das idades é de {0}.", i);
  }
}