using System;

class Program {
  public static void Main (string[] args) {
    double c, d;
    
    Console.WriteLine ("Digite '1' para vermelho, '2' para amarelo ou '3' para verde.");
    c = double.Parse(Console.ReadLine());
    Console.WriteLine ("Qual a atual distância do cruzamento em metros?");
    d = double.Parse(Console.ReadLine());

    if( c==1 || (c==2 && d>=5) ){
      Console.WriteLine("Pare.");
    }
    else if(c==2 && d<5){
      Console.WriteLine("Passe com cuidado.");   
    }
    else if(c==3){
      Console.WriteLine("Passe.");
    }
  }
}

/*
INICIO
var c, d: reais
    
escreva "Digite '1' para vermelho, '2' para amarelo ou '3' para verde."
leia c
escreva "Qual a atual distância do cruzamento em metros?"
leia d

se c==1 || (c==2 && d>=5)
  escreva "Pare."
se não se c==2 && d<5
  escreva "Passe com cuidado."
se não se c==3
  escreva "Passe."
fim se
FIM
*/