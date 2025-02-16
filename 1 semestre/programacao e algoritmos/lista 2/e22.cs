using System;

class Program {
  public static void Main (string[] args) {
    int cp;
    Console.WriteLine ("Escreva o código do produto.");
    cp = int.Parse(Console.ReadLine());

    if(cp==1){
      Console.WriteLine("Alimento não perecível.");
    }
    else if(cp==2 || cp==3 || cp==4){
      Console.WriteLine("Alimento perecível.");
    }
    else if(cp==5 || cp==6){
      Console.WriteLine("Vestuário.");
    }
    else if(cp==7){
      Console.WriteLine("Higiene.");
    }
    else if(cp==8 || cp==9){
      Console.WriteLine("Limpeza e untensílios domésticos.");
    }
    else{
      Console.WriteLine("Código inválido.");
    }
  }
}

/*
INICIO
int cp;
escreva "Escreva o código do produto."
leia cp

se cp==1
  escreva "Alimento não perecível."
se não cp==2 || cp==3 || cp==4
  escreva "Alimento perecível."
se não cp==5 || cp==6)
  escreva "Vestuário."
se não cp==7
  escreva "Higiene."
se não cp==8 || cp==9
  escreva "Limpeza e untensílios domésticos."
se não
  escreva "Código inválido."
fim se
FIM
*/