using System;

class Program {
  public static void Main (string[] args) {
    int a, b, c;
    Console.Write ("Digite a 1ª variável. "); a = int.Parse(Console.ReadLine());

    Console.Write ("Digite a 2ª variável. "); b = int.Parse(Console.ReadLine());

    Console.Write ("Digite a 3ª variável. "); c = int.Parse(Console.ReadLine());

    Console.WriteLine (a*b*c);
  }
}