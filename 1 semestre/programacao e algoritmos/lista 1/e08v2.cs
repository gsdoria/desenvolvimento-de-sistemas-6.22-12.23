using System;

class Program {
  public static void Main (string[] args) {
  double pag, he, me, hs, ms, hora, min;

  Console.WriteLine("Escreva a hora de entrada.");
  he = double.Parse(Console.ReadLine());
  
  Console.WriteLine("Escreva o minuto de entrada.");
  me = double.Parse(Console.ReadLine());

  Console.WriteLine("Escreva a hora de saída.");
  hs = double.Parse(Console.ReadLine());
  
  Console.WriteLine("Escreva o minuto de saída.");
  ms = double.Parse(Console.ReadLine());

  hora = hs-he; min = ms-me; pag = 4*hora + min/15;
  pag = (Math.Ceiling( pag*100 )) / 100;

  Console.WriteLine("O pagamento é de {0} reais",pag);
  }
}