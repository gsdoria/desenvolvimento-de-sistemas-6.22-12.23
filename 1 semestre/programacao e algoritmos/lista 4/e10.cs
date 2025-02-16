using System;

class Program {
  public static void Main (string[] args) {
    string n1, n2;
    int i=0;
    Console.Write ("Escreva seu nome. "); n1 = Console.ReadLine();
    
    Console.Write ("Digite sua idade. ");
    i += int.Parse(Console.ReadLine());

    Console.Write ("\nEscreva seu nome. "); n2 = Console.ReadLine();
    
    Console.Write ("Digite sua idade. ");
    i += int.Parse(Console.ReadLine());

    Console.WriteLine("A soma das idades de {0} e {1} é de {2}.", n1, n2, i);
  }
}