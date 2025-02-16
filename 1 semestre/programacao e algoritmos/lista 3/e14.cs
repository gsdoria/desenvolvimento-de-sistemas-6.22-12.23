using System;

class Program {
  public static void Main (string[] args) {
    double ht, vh, br, inss, lq, ir;
    Console.Write("Quantas horas você trabalhou? ");
    ht = double.Parse(Console.ReadLine());
    Console.Write("Escreva o valor das horas trabalhadas. ");
    vh = double.Parse(Console.ReadLine());
    
    br = vh*ht;
    inss = 0.11*br;
    
    if (br-inss <= 1257.12){ 
      ir = 0; 
      lq = br-inss-ir; 
    } 
    else if (br-inss <= 2512.08){ 
      ir = 0.15*(br-inss)-188.57; 
      lq = br-inss-ir; 
    } 
    else { 
      ir = 0.275*(br-inss)-502.58; 
      lq = br-inss-ir; 
    }
    Console.WriteLine("O valor líquido é de R${0:F2}.",lq);
  }
}

/*
INICIO
var ht, vh, br, inss, lq, ir: reais
escreva "Quantas horas você trabalhou? "
leia ht
escreva "Escreva o valor das horas trabalhadas. "
leia vh

br = vh*ht;

se br-inss <= 1257.12
  lq = br-inss
se não se br-inss <= 2512.08
  ir = 0.15*(br-inss)-188.57 
  lq = br-inss-ir
se não
  ir = 0.275*(br-inss)-502.58
  lq = br-inss-ir

escreva "O valor líquido é de R$", lq,"."
FIM
*/