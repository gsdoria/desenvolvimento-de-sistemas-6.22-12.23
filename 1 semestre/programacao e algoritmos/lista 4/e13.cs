using System;

class Program {
  public static void Main (string[] args) {
    int x, y, z;
    Console.Write ("Digite a 1ª variável. "); x = int.Parse(Console.ReadLine());

    Console.Write ("Digite a 2ª variável. "); y = int.Parse(Console.ReadLine());

    Console.Write ("Digite a 3ª variável. "); z = int.Parse(Console.ReadLine());

    Console.WriteLine (5*x*y*z);
  }
}