using System;

class Program {
  public static void Main (string[] args) {
    double pag, he=0, me=0, ce=1, hs=0, ms=0, cs=1, hora, min;

    while (ce>0){
        Console.Write ("Escreva a hora de entrada. ");
        he = double.Parse(Console.ReadLine());
        Console.Write ("Escreva o minuto de entrada. ");
        me = double.Parse(Console.ReadLine());

        if (he<0 || he>23){ Console.WriteLine ("\nHora inválida."); }
        if (me<0 || me>59){ Console.WriteLine ("\nMinuto inválido.\n"); }
        else { ce=0; }
    }

    while (cs>0) {
      Console.Write ("\nEscreva a hora de saída. ");
      hs = double.Parse(Console.ReadLine());
      Console.Write ("Escreva o minuto de saída. ");
      ms = double.Parse(Console.ReadLine());

      if ( hs<0 || hs>23 ){ Console.WriteLine ("\nHora inválida."); }
      if ( ms<0 || ms>59 ){ Console.WriteLine ("\nMinuto inválido.\n"); }
      
      else { cs=0; }
    }
  
    if( hs<he ){ hs+=24; }

    hora = hs-he;
    min = ms-me;

    if ( min>0 ){ hora += 1; }
    
    if ( hora==1 ){ pag = 4; }
    
    else if ( hora==2 ){ pag = 6; }
    
    else { pag = 4 + hora; }
  
    Console.WriteLine ("O pagamento é de R${0:F2}.", pag);
  }
}

/*
INICIO
var pag, he=0, me=0, ce=1, hs=0, ms=0, cs=1, hora, min: tipo real

enquanto ce>0 faça
  escreva "Escreva a hora de entrada."
  leia he
  escreva "Escreva o minuto de entrada."
  leia me

  se he<0 || he>23
    escreva "Hora inválida."
  se me<0 || me>59
    escreva "Minuto inválido."
  senão
    ce=0
  fim se
fim enquanto

enquanto cs>0 faça
  escreva "Escreva a hora de saída."
  leia hs
  escreva "Escreva o minuto de saída."
  leia ms

  se hs<0 || hs>23
    escreva "Hora inválida."
  se ms<0 || ms>23
    escreva "Minuto inválido."
  senão
    ce=0
  fim se
fim enquanto

se hs<he
  hs = hs+24
fim se

hora = hs-he
min = ms-me

se min>0
  hora = hora+1
fim se

se hora == 1
  pag = 4
se não se hora == 2
  pag = 6
se não
  pag = 4 + hora
fim se

escreva "O pagamento é de R$", pag, "."
FIM
*/