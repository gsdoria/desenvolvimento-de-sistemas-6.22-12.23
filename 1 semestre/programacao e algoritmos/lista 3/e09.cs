using System;

class Program {
  public static void Main (string[] args) {
    double b = double.NegativeInfinity, s = double.PositiveInfinity, x, i=0;
    
    do {
      Console.Write ("Escreva um número. ");
      x = int.Parse(Console.ReadLine());

      if (s>x){ s=x; }
      if (b<x){ b=x; }

      i++;
    } while (i<20);
    
    Console.WriteLine ("O maior número foi {0} e o menor {1}.", b, s);
  }
}

/*
INICIO
var b = -infinito, s = infinito, x, i=0: reais

faça
  escreva "Escreva um número."
  leia x

  se s>x
    x = n1
  fim se

  se b<x
    x = n1
  fim se

  i++
enquanto i<20

escreva "O maior número foi ", b, " e o menor ", s, "."
FIM
*/