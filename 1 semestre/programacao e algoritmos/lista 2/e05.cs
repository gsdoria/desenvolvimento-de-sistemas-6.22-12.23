using System;

class Program {
  public static void Main (string[] args) {
    int n;

    Console.WriteLine("Digite um número inteiro");
    n = int.Parse(Console.ReadLine());

    if(n<0){
      n *= -1;
    }

    Console.WriteLine("Seu módulo é "+n+".");
    
  }
}

/*
INICIO
var n: inteiro

escreva "Digite um número inteiro."
leia n

se n<0
  n *= -1
fim se

escreva "Seu módulo é", n, "."
FIM
*/