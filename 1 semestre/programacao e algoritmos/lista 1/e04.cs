using System;

class Program {
  public static void Main (string[] args) {
    double pr, d, pag;
    
    Console.WriteLine("Escreva o preço do produto.");
    pr = double.Parse(Console.ReadLine());

    Console.WriteLine("Escreva a porcentagem de desconto.");
    d = double.Parse(Console.ReadLine());
    
    pag = pr*(1-d/100);
    
    Console.WriteLine("O preço com desconto é de "+pag+",00R$.");   
  }
}