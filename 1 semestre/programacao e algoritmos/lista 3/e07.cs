using System;

class Program {
  public static void Main (string[] args) {
    int n, r=1;

    Console.Write("Escreva o fatorial. ");
    n = int.Parse(Console.ReadLine());

    if(n>0){
      for(int i=1; i<=n; i++){
        r *= i;
      }
      Console.WriteLine("O fatorial é igual a {0}.", r);
    } else if (n==0){
      Console.WriteLine("O fatorial é igual a 1.");
    } else {
      Console.WriteLine("O fatorial de um número negativo não pode ser feito.");
    }
  }
}

/*
INICIO
var n, r=0: inteiros

escreva "Escreva o fatorial."
leia n

se n>0
  para i de 1 até n passo 1 faça
    r = r + i
  fim para
  escreva "O fatorial é igual a ", r, "."
se não se n==0
  escreva "O fatorial é igual a 1."
se não
  escreva "O fatorial de um número negativo não pode ser feito."
fim se
FIM
*/