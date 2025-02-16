using System;

class Program {
  public static void Main (string[] args) {
    double ht, vh, br, inss, lq, ir;
    Console.Write("Quantas horas você trabalhou? ");
    ht = double.Parse(Console.ReadLine());
    Console.Write("Escreva o valor das horas trabalhadas. ");
    vh = double.Parse(Console.ReadLine());
    
    br = vh*ht;

    if(br <= 800.45) inss = 0.0765*br;
    else if(br <= 900) inss = 0.0865*br;
    else if(br <= 1334.07) inss = 0.09*br;
    else if(br <= 2668.15) inss = 0.11*br;
    else inss = 293.5;
    
    if (br-inss <= 1257.12){ 
      lq = br-inss; 
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

se br <= 800.45) 
  inss = 0.0765*br
se não se br <= 900
  inss = 0.0865*br
se não se br <= 1334.07
  inss = 0.09*br
se não se br <= 2668.15
  inss = 0.11*br
se não
  inss = 293.5

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