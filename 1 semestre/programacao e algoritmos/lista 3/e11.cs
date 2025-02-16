using System;

class Program {
  public static void Main (string[] args) {
    double n, s=0, i=1, m;

    while (i>0){
      Console.Write ("Digite um número inteiro positivo. ");
      n = double.Parse(Console.ReadLine());

      if(n<0){
        i--;
        m = s/i;
        Console.WriteLine("A soma é igual a {0} e a média a {1}", s, m);
        i *= -1;
      } else {
        s += n;
        i++;
      }
    }
    
  }
}

/*
INICIO
var n, s=0, i=1, m: reais

enquanto i>0 faça
  escreva "Digite um número inteiro positivo."
  leia n

  se n<0
    i = i-1
    m = s/i
    escreva "A soma é igual a {s} e a média a {m}."
    i = i* -1
  se não
    s = s+n
    i = i+1
  fim se

fim enquanto

FIM
*/