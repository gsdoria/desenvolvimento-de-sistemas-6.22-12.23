using System;

class Program {
  public static void Main (string[] args) {
    double pr, d, pag;
    
    Console.WriteLine("Escreva o preço original do produto.");
    pr = double.Parse(Console.ReadLine());

    Console.WriteLine("Escreva o preço atual do produto.");
    pag = double.Parse(Console.ReadLine());
    
    d = (1-pag/pr) * 100;
    
    Console.WriteLine("O desconto foi de "+d+"%.");
  }
}