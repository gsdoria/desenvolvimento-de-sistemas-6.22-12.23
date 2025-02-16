using System;

class Program {
  public static void Main (string[] args) {
    double vh, ht, ir, br;
    string c = "s";

    while(c=="s"){
      Console.Write ("Escreva quantas horas trabalhou. ");
      ht = double.Parse(Console.ReadLine());

      Console.Write ("Escreva o valor da hora trabalhada. ");
      vh = double.Parse(Console.ReadLine());

      br = vh*ht;

      if (br*0.89<900) { ir = 0; }
      
      else if (br*0.89<=1800) {
        ir = 0.15*(br*0.89)-135;
        br -= ir;
      }

      else {
        ir = 0.275*(br*0.89)-360;
        br -= ir;
      }
      Console.WriteLine("\nSeu salário liquido é de R${0:F2}. \n", br);
      Console.Write ("Digite \"s\" caso queira realizar outro cálculo ou \"n\" caso não. ");
      c = Console.ReadLine();


      while ( !"sn".Contains(c) ) {
        Console.WriteLine("Resposta inválida.\n");

        Console.Write ("Digite \"s\" caso queira realizar outro cálculo ou \"n\" caso não. ");
        c = Console.ReadLine();
      }
    }
  }
}


/*
INÍCIO

var vh, ht, ir, br: reais
var c = "s": texto

enquanto c=="s" faça
  escreva "Escreva quantas horas trabalhou."
  leia ht

  escreva "Escreva o valor da hora trabalhada."
  leia vh

  br = vh*ht

  se br*0.89<900
    ir = 0
  
  senão se br*0.89<=1800
    ir = 0.15*(br*0.89)-135
    br -= ir
  senão
    ir = 0.275*(br*0.89)-360
    br -= ir
  fim se

  escreva "Seu salário liquido é de R$", br, "."
  
  escreva "Digite "s" caso queira realizar outro cálculo ou "n" caso não."
  leia c

  enquanto "sn" não contenha c faça
    escreva "Resposta inválida."

    escreva "Digite "s" caso queira realizar outro cálculo ou "n" caso não."
    leia c
  fim enquanto

fim enquanto

FIM
*/