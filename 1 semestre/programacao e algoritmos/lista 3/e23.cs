using System;

class Program {
  public static void Main (string[] args) {
    double s=1, sn, a=0;

    while (s>0) {
      Console.Write ("Escreva o valor de seu salário. ");
      s = double.Parse(Console.ReadLine());

      if (s>0) {
        if (s<500) { sn = s * 1.15; a += sn-s; }

        else if (s<=1000) { sn = s * 1.1; a += sn-s; }

        else { sn = s * 1.05; a += sn-s; }
      }
    }
    Console.WriteLine ("\nOs gastos extras serão de R${0:F2}.", a);
  }
}

/*
INÍCIO

var s=1, sn, a=0: reais

enquanto s>0 faça
  escreva "Escreva o valor de seu salário."
  leia s

  se s>0
    se s<500
      sn = s * 1.15
      a += sn-s
    senão se s<=1000
      sn = s * 1.1
      a += sn-s;
    senão
      sn = s * 1.05
      a += sn-s
    fim se
  fim se
fim enquanto

escreva "Os gastos extras serão de R$", a, "."

FIM
*/