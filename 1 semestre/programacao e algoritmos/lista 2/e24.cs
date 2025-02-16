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
  pag = 4*hora;
    
  if( min>0 ){ pag++; }

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
pag = 4*hora

se min>0
  pag = pag+1
fim se

escreva "O pagamento é de R$",pag,"."
FIM
*/