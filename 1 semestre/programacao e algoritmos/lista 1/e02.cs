using System;

class Program {
  public static void Main (string[] args) {
    double l, c, a, p;

    Console.WriteLine("Escreva a largura da sala em metros.");
    l = double.Parse(Console.ReadLine());

    Console.WriteLine("Escreva o comprimento da sala em metros.");
    c = double.Parse(Console.ReadLine());

    a = l*c; 
    p = 2*(l+c);
    
    Console.WriteLine("A área da sala é de "+a+"m².");
    Console.WriteLine("O perimetro da sala é de "+p+"m.");
    
  }
}