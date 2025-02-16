using System;

class Program {
  public static void Main (string[] args) {
    double c, q=1, p, pt=0;
    
    Console.Write ("Escreva quanto dinheiro há no caixa da empresa em reais. ");
    c = double.Parse(Console.ReadLine());

    while(q>0){
      Console.Write ("\nEscreva a quantidade de produtos a serem comprados. ");
      q = double.Parse(Console.ReadLine());

      if(q>0){
        
        Console.Write ("Escreva o preço individual do produto em reais. ");
        p = double.Parse(Console.ReadLine());

        while(p<=0){
          Console.WriteLine("Preço inválido.\n");
          Console.Write ("Escreva o preço individual do produto em reais. ");
          p = double.Parse(Console.ReadLine());
        }
        pt += q*p;
      }
    }
    
    if (pt>c*0.8) {
      Console.WriteLine("Será pago em 3x e o valor das parcelas serão de R${0:F2}, com o preço total de R${0:F2}.", pt*1.1, pt*1.1/3); }
    else {
      Console.WriteLine("Será pago a vista e o valor total será de R${0:F2}.", pt*0.95); }
    
  }
}

/*
INÍCIO

var c, q=1, p, pt=0: texto
    
escreva "Escreva quanto dinheiro há no caixa da empresa em reais."
leia c

enquanto q>0 faça
  escreva "Escreva a quantidade de produtos a serem comprados."
  leia q

  se q>0
    escreva "Escreva o preço individual do produto em reais."
    leia p

    enquanto p<=0 faça
      escreva "Preço inválido."
      escreva "Escreva o preço individual do produto em reais."
      leia p
    fim enquanto

    pt += q*p
  fim se
fim enquanto

se pt>c*0.8
  escreva "Será pago em 3x e o valor das parcelas serão de R$", pt*1.1, ", com o preço total de R$", pt*1.1/3, "."
senão
  Console.WriteLine("Será pago a vista e o valor total será de R$",  pt*0.95, "."
fim sem

FIM
*/