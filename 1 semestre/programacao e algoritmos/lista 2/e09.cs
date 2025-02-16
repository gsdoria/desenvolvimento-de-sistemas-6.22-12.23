using System;

class Program {
  public static void Main (string[] args) {
    double s;

    Console.WriteLine("Escreva o valor de seu salário.");
    s = double.Parse(Console.ReadLine());

    if(s<500){ s *= 1.15;}
    else if(s<1000){ s *= 1.1;}
    else{ s *= 1.05; }

    Console.WriteLine("O novo salário será de "+s+" reais.");
    
  }
}

/*
INICIO
var s:real

escreva "Escreva o valor de seu salário."
leia s

se s<500
  s *= 1.15
se não se s<1000
  s *= 1.1
se não
  s *= 1.05
fim se

escreva "O novo salário será de ", s, " reais."

FIM
*/