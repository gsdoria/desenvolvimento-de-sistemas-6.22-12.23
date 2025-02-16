using System;

class Program {
  public static void Main (string[] args) {
    double pr, co;
    Console.WriteLine ("Escreva o preço do produto.");
    pr = double.Parse(Console.ReadLine());

    Console.WriteLine ("Escreva o código de origem do produto.");
    co = double.Parse(Console.ReadLine());

    Console.Write("O preço do produto é de R${0:F2} e ", pr);
    
    if(co==1){ Console.Write("o produto veio do Sul."); }
    else if(co==2){ Console.Write("o produto veio do Sudeste."); }
    else if(co==3){ Console.Write("o produto veio do Centro."); }
    else if(co==4){ Console.Write("o produto veio do Norte."); }
    else if(co==5){ Console.Write("o produto veio do nordeste."); }
    else{ Console.WriteLine("e o código de origem é inválido."); }
  }
}

/*
INICIO
var pr, co: reais

escreva "Escreva o preço do produto."
leia pr

escreva "Escreva o código de origem do produto."
leia co

escreva "O preço do produto é de R$", pr, " e "

se co==1
  escreva "o produto veio do Sul."
se não se co==2 
  escreva "o produto veio do Sudeste."
se não se co==3 
  escreva "o produto veio do Centro."
se não se co==4
  escreva "o produto veio do Norte."
se não se co==5
  escreva "o produto veio do nordeste."
se não 
  escreva "e o código de origem é inválido."
fim se

FIM
*/