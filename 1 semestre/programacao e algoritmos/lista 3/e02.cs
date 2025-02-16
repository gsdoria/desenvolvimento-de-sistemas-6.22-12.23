using System;

class Program {
  public static void Main (string[] args) {
    double q, p, gt=0;
    for(int i=1; i<=45; i++){
      Console.Write("Escreva a quantidade comprada do produto {0}. ", i);
      q = double.Parse(Console.ReadLine());
      Console.Write("Escreva o preço do produto comprado. ");
      p = double.Parse(Console.ReadLine());
      gt = q*p;
    }
    Console.WriteLine("O gasto total foi de R${0:F2}.", gt);
  }
}

/*
INICIO

var q, p, gt=0 : reais

para i de 1 até 40 passo 1 faça
  escreva "Escreva a quantidade comprada do produto ", i, ". "
  leia q
  escreva "Escreva o preço do produto comprado. "
  leia p
  gt = gt + q*p
fim para

escreva "O gasto total foi de R$", gt, "."

FIM
*/