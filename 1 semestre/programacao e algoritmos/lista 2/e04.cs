using System;

class Program {
  public static void Main (string[] args) {
    double ct, vg;
    string tc;

    Console.WriteLine("Escreva a capacidade do tanque em litros.");
    ct = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite g para gasolina ou a para álcool.");
    tc = Console.ReadLine();

    if(tc=="g"){ 
      vg = ct*1.8; 
    }
    else{ 
      vg = ct; 
    }

    Console.WriteLine("O preço será de "+vg+" reais.");
  }
}

/*
INICIO

var ct, vg: reais
var tc; texto

escreva "Escreva a capacidade do tanque."
leia ct

escreva "Digite g para gasolina ou a para álcool."
leia tc

se tc=="g"
  vg = ct*1.8
se não
  vg = ct
fim se

escreva ""O preço será de ", vg, " reais."

FIM
*/