using System;

class Program {
  public static void Main (string[] args) {
    int n = 1;

    while (n>0){
      Console.WriteLine ("Escreva um número inteiro positivo.");
      n = int.Parse(Console.ReadLine());

      if (n>0) {
        if ( n%2 == 0) { Console.WriteLine("O número é par."); n *= -1; }
        else { Console.WriteLine("O número é impar."); n *= -1; }
        
      } else {
        Console.WriteLine("Escreva apenas números positivos.\n"); n = 1; }
    }
  }
}

/*
INICIO
var n=1 : inteiro

enquanto n>0 faça
  escreva "Escreva um número inteiro positivo."
  leia n

  se n>0
    se n%2==0
      escreva "O número é par."
      n *= -1
    senão
      escreva "O número é impar."
      n *= -1
    fim se
  senão
    escreva "Escreva apenas números positivos."
    n = 1
  fim se
fim enquanto

FIM
*/