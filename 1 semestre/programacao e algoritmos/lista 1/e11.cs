using System;

class Program {
  public static void Main (string[] args) {
    float qtd, ct, lt, cp, lp, dc, dl;

    Console.WriteLine("Comprimento dos tijolos em cm.");
    ct = float.Parse(Console.ReadLine());

    Console.WriteLine("Largura dos tijolos em cm.");
    lt = float.Parse(Console.ReadLine());

    Console.WriteLine("Comprimento da parede em cm.");
    cp = float.Parse(Console.ReadLine());
    
    Console.WriteLine("Largura da parede em cm.");
    lp = float.Parse(Console.ReadLine());
    
    dc = cp/ct; dl = lp/lt;
    qtd = dc * dl;
      
    Console.WriteLine("A quantidade de tijolos necessária é de {0}.",qtd);
  }
}