using System;

class Program {
  public static void Main (string[] args) {
    int dn=0, mn=0, an=0, da=0, ma=0, aa=0, i, cn=1, ca=1;

    while (cn>0){
      Console.Write ("Escreva o dia de seu nascimento. ");
      dn = int.Parse(Console.ReadLine());
      Console.Write ("Escreva o número do mês de seu nascimento. ");
      mn = int.Parse(Console.ReadLine());

      if (dn>31 || dn<0) { Console.WriteLine ("Dia inválido.\n"); }

      if (mn>12 || mn<0) { Console.WriteLine ("Mês inválido.\n"); }

      else {
        cn=0;
        Console.Write ("Escreva o ano de seu nascimento. ");
        an = int.Parse(Console.ReadLine());
      }
    }

    while (ca>0){
      Console.Write ("\nEscreva o dia atual. ");
      da = int.Parse(Console.ReadLine());
      Console.Write ("Escreva o número do mês atual. ");
      ma = int.Parse(Console.ReadLine());

      if (da>31 || da<0) { Console.WriteLine ("Dia inválido.\n"); }

      if (ma>12 || ma<0) { Console.WriteLine ("Mês inválido.\n"); }

      else {
        ca=0;     
        Console.Write ("Escreva o ano atual. ");
        aa = int.Parse(Console.ReadLine());
      }
    }

    i = aa-an;
    if (ma<mn) { i--; }
    else if (da<dn) { i--; }

    Console.WriteLine("Você tem {0} anos", i);
  }
}


/*
INICIO
var dn=0, mn=0, an=0, da=0, ma=0, aa=0, i, cn=1, ca=1: inteiro

enquanto cn>0 faça

  escreva "Escreva o dia de seu nascimento."
  leia dn
  escreva "Escreva o número do mês de seu nascimento."
  leia mn

  se da>31 || da<0
    escreva "Dia inválido."
  se ma>12 || ma<0
    escreva "Mês inválido."
  senão
    cn=0
    escreva "Escreva o ano de seu nascimento."
    leia an
  fim se

fim enquanto

enquanto ca>0 faça
  escreva "Escreva o dia atual."
  leia da
  escreva "Escreva o número do mês atual."
  leia ma

  se da>31 || da<0
    escreva "Dia inválido."
  se ma>12 || ma<0
    escreva "Mês inválido."
  senão
    cn=0
    escreva "Escreva o ano atual."
    leia an
  fim se

fim enquanto

i = aa-an

se ma<mn 
  i--
senão se da<dn
  i--
fim se

escreva "Você tem ",i ," anos"
FIM
*/