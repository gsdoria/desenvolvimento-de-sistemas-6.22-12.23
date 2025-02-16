using System;

class Program {
  public static void Main (string[] args) {
    int h=0;
    for(int i=1; i<=30; i++){
      Console.Write ("Digite quantas horas trabalhou no dia {0}. ", i);
      h += int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Seu salário bruto é de R${0:F2}.", h*10);
  }
}

/*
INICIO
var h=0: inteiro

para i de 1 até 30 passo 1 faça
  escreva "Digite quantas horas trabalhou no dia ", i, "."
  h = h + leia h
fim para
escreva "Seu salário é de R$", h*10, "."

FIM
*/