using System;

class Program {
  public static void Main (string[] args) {
    double pag, he, me, hs, ms, hora, min;

    Console.WriteLine("Escreva a hora de entrada.");
    he = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Escreva o minuto de entrada.");
    me = double.Parse(Console.ReadLine());
  
    Console.WriteLine("Escreva a hora de saída.");
    hs = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Escreva o minuto de saída.");
    ms = double.Parse(Console.ReadLine());
  
    if( hs<he ){ hs+=24; }

    hora = hs-he;
    min = ms-me;

    if ( min>0 ){ hora+=1; }
    
    if ( hora==1 ){
      pag = 4;
    }
    else if ( hora==2 ){
      pag = 6;
    }
    else {
      pag = 4 + hora;
    }
  
    Console.WriteLine("O pagamento é de R${0:F2}.", pag);
  }
}

/*
INICIO
var pag, he, me, hs, ms, hora, min: tipo real

Escreva "Escreva a hora de entrada."
leia he

Escreva "Escreva o minuto de entrada."
leia me

Escreva "Escreva a hora de saída."
leia hs

Escreva "Escreva o minuto de saída."
leia ms

se hs<he
  hs = hs+24
fim se

hora = hs-he
min = ms-me

se min>0
  hora = hora+1
fim se

se hora==1
  pag = 4
se não se hora==2
  pag = 6
se não
  pag = 4 + hora
fim se

escreva "O pagamento é de R$",pag,"."
FIM
*/