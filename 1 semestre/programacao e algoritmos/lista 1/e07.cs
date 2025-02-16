using System;

class Program {
  public static void Main (string[] args) {
    double r, v;
    
    Console.WriteLine("Escreva o raio em metros.");
    r = double.Parse(Console.ReadLine());

    v = 4/3 * 3.14 * r*r*r;
    
    Console.WriteLine("O volume é da esfera é de "+v+"m³.");
  }
}