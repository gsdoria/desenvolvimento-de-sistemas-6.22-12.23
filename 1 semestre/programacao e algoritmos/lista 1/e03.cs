using System;

class Program {
   public static void Main (string[] args) {
    double pr, d;
    
    Console.WriteLine("Escreva o preço do produto.");
    pr = double.Parse(Console.ReadLine());

    d = pr*(1-0.05);
    
    Console.WriteLine("O preço com desconto é de "+d+",00R$.");   
  }
}