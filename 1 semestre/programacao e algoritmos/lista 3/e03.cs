using System;

class Program {
  public static void Main (string[] args) {
    int h=0;
    for(int i=1; i<=30; i++){
      Console.Write ("Digite quantas horas trabalhou no dia {0}. ", i);
      h += int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Você trabalhou {0} horas no mês.", h);
  }
}

/*
INICIO
var h=0: inteiro

para i de 1 até 30 passo 1 faça
  escreva "Digite quantas horas trabalhou no dia ", i, "."
  h = h + leia h
fim para
escreva "Você trabalhou ", h, "horas no mês."

FIM
*/