using System;

class Program {
  public static void Main (string[] args) {
    int n, r=0;

    Console.Write("Escreva o limite da operação. ");
    n = int.Parse(Console.ReadLine());
    
    for(int i=1; i<=n; i++){
      r += i;
    }
    Console.WriteLine("A soma é igual a {0}.", r);
  }
}

/*
INICIO
var n, r=0: inteiros

escreva "Escreva o limite da operação."
leia n

para i de 1 até n passo 1 faça
  r = r + i
fim para

escreva "A soma é igual a ", r, "."
FIM
*/