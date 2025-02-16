using System;

class Program {
  public static void Main (string[] args) {
    double n, q, p, t=0, i=1;
    
    Console.Write ("Escreva a quantidade de produtos diferentes comprados. ");
    n = double.Parse(Console.ReadLine());

    while(i<=n){
        
      Console.Write ("\nEscreva a quantidade comprada do produto {0}. ", i);
      q = double.Parse(Console.ReadLine());
      Console.Write ("Escreva o preço individual do produto. ");
      p = double.Parse(Console.ReadLine());

      if(p<0 || q<0){ 
        Console.WriteLine("Quantidade ou preço inválido."); 
      } else {
        t += q*p; 
        i++;
      }  
    }

    Console.WriteLine("\nO total gasto foi de R${0:F2}.", t);
  }
}

/*
INICIO
var n, p, q, t=0, i=1: reais

escreva "Escreva a quantidade de produtos diferentes comprados."
leia n

enquanto i<=n+1 faça

  escreva "Escreva a quantidade comprada do produto ", i, "."
  leia q
  escreva "Escreva o preço individual do produto."
  leia p

  se p<0 || q<0
    escreva "Quantidade ou preço inválido."
  se não
    t = t + q*p; 
    i = i+1;
  fim se
fim enquanto

escreva "O total gasto foi de R$", t, "."

FIM
*/