using System;

class Program {
  public static void Main (string[] args) {
    float p;

    Console.WriteLine("Esreva o preço do produto em reais.");
    p = float.Parse(Console.ReadLine());

    if (p>50 && p<100) { Console.WriteLine("Em promoção."); }
    else { Console.WriteLine("Preço normal."); }
  }
}

/*
INICIO
var p: real

escreva "Esreva o preço do produto em reais."
leia p

se p>50 && p<100
  escreva "Em promoção."
se não
  escreva "Preço normal."
fim se

FIM
*/