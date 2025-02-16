using System;

class Program {
  public static void Main (string[] args) {
    int i=0, n;
    
    while (i>=0) {
      Console.Write ("Digite um número inteiro positivo. ");
      n = int.Parse(Console.ReadLine());

      if (n>i) {
        i = n;
      } else if (n<0) {
        i *= -1;
      }
    }

    Console.WriteLine("O maior número foi {0}.", -i);
    
  }
}

/*
INICIO

var i=0, n: inteiros

enquanto i>=0 faça
  escreva "Digite um número inteiro positivo."
  leia n

  se n>i
    i = n
  se não se n<0
    i = -i
  fim se
fim enquanto

escreva "O maior número foi", -i, "."

FIM
*/