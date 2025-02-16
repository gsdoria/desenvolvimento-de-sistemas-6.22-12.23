using System;

class Program {
  public static void Main (string[] args) {
    double n;
    
    Console.Write ("Escreva um número. ");
    n = double.Parse(Console.ReadLine());

    for(int i=-1000; i<=100; i++){
      Console.WriteLine ("{0} x {1} = {2:F1}", i, n, n*i);
    }
  }
}

/*
INICIO

var n: real

escreva "Escreva um número."
leia n

para i de 0 até 10 passo 1 faça
  escreva i, " x ", n, " = ", n*i
fim para

FIM
*/