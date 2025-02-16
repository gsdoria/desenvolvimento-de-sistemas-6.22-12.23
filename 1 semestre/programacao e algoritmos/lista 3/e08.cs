 using System;

class Program {
  public static void Main (string[] args) {
    double n, m = Double.NegativeInfinity, i=1;

    do {
      Console.Write ("Escreva um número. ");
      n = int.Parse(Console.ReadLine());
      
      if (n>m) { m = n; }

      i++;
    } while(i<20);
    
    Console.WriteLine ("O maior número foi {0}.", m);
  }
}

/*
INICIO
var n, m = -infinito, i=0: real

faça
  escreva "Escreva um número."
  leia n
  se n>m
    m = n
  fim se
  i++
enquanto i<20

escreva "O maior número foi ", m, "."
FIM
*/