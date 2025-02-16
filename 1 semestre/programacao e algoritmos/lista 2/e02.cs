using System;

class Program {
  public static void Main (string[] args) {
    float cl;

    Console.WriteLine("Escreva o valor da conta de luz.");
    cl = float.Parse(Console.ReadLine());

    if(cl>50){
      Console.WriteLine("Você está gastando muito.");
    }
    else{
      Console.WriteLine("Seu gasto foi normal.");
    }
  }
}