using System;

class Program {
  public static void Main (string[] args) {
    double cx, qtd, pr, pt;
    
    Console.WriteLine ("Escreva quanto dinheiro há no caixa da empresa em reais.");
    cx = double.Parse(Console.ReadLine());

    Console.WriteLine ("Escreva quanto dinheiro cada produto custa individualmente em reais.");
    pr = double.Parse(Console.ReadLine());
    
    Console.WriteLine ("Escreva a quantidade de produtos a serem comprados.");
    qtd = double.Parse(Console.ReadLine());
    
    pt = qtd*pr;

    if (pt>cx*0.8) {
      Console.WriteLine("Será pago em 3x e o valor total será de "+pt*1.1+" reais.");
    } else {
      Console.WriteLine("Será pago a vista e o valor total será de "+pt*0.95+" reais.");
    }
  }
}

/*
INICIO
var cx, qtd, pr, pt: reais

escreva "Escreva quanto dinheiro há no caixa da empresa em reais."
leia cx

escreva "Escreva quanto dinheiro cada produto custa individualmente em reais."
leia pr

escreva "Escreva a quantidade de produtos a serem comprados."
leia qtd

pt = qtd*pr

se pt>cx*0.8
  escreva "Será pago em 3x e o valor total será de "+pt*1.1+" reais."
se não
  escreva "Será pago a vista e o valor total será de "+pt*0.95+" reais."
fim se

FIM
*/