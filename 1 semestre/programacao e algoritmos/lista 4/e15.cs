using System;

class Program {
  public static void Main (string[] args) {
    Console.Write ("Digite uma temperatura em graus Farenheit. ");
    Console.WriteLine("A temperatura em graus celsius é de {0:F2}°.", (double.Parse( Console.ReadLine() ) - 32 )*5/9 );
  }
}