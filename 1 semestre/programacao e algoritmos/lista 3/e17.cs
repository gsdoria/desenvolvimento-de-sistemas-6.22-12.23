using System;

class Program {
  public static void Main (string[] args) {
    double a = 0, i = 1;
    string r = "s" ;
    
    while (i > 0) {

      if (r == "s") {      
        Console.Write ("\nEscreva a área do cômodo. ");
        a += int.Parse(Console.ReadLine());
        r = "a";
      }

      else {
        Console.Write ("\nDigite 's' para continuar e 'n' para apresentar a área da casa. ");
        r = Console.ReadLine();
        
        if (r == "n"){
          Console.WriteLine("\nA área total da casa é de {0}m².", a);
          i = 0;
        } else if (r != "s") {
          Console.WriteLine("\nResposta inválida.");
        }
      }
    }
    
  }
}

/*
INICIO
var a=0, i=1: real
var r="s": texto

enquanto i>0 faça

  se r == "s"
    escreva "Escreva a área do cômodo."
    a += leia
    r = "a"
  fim se

  senão
    escreva "Digite 's' para continuar e 'n' para apresentar a área da casa."
    leia r
  
    se r=="n"
      escreva "A área total da casa é de ", a, "m² ."
      i=0
    senão se r!="s"
      escreva "Resposta inválida."
    fim se
fim enquanto

FIM
*/