using System;

class Program {
  public static void Main (string[] args) {
    double n = double.PositiveInfinity, n1;
    string r = "s", r1 = "";
    bool continuar = true;
    
    while(r=="s"){
      continuar = true;
      
      n1 = n;
      
      Console.Write ("Digite um número inteiro. ");
      n = int.Parse(Console.ReadLine());

      if(n1<n){
        n = n1;
      }

      while (continuar){
        Console.Write("\nDeseja continuar? ");
        r1 = Console.ReadLine();

        if ( r1 == "s" ) {
          continuar = false;
        } else if ( r1 == "n" ){
          continuar = false;
          r = "n";
        } else {
          Console.WriteLine ("Resposta inválida.\n");
        }
      }
      r = r1;
    }

    Console.WriteLine("\nO menor número foi {0}.", n);
    
  }
}

/*
INICIO
var n = infinito, n1: real
var r = "s", r1 = "": texto
var continuar = verdade: booleano

enquanto r=="s"
  continuar = verdade
  
  n1 = n
  
  escreva "Digite um número inteiro."
  leia n

  se n1<n
    n = n1
  fim se

  enquanto continuar
    escreva "Deseja continuar?"
    leia r1

    se r1 == "s"
      continuar = falso

    se não se r1 == "n"
      continuar = falso
      r = "n"

    se não 
      escreva "Resposta inválida."
    fim se
  fim enquanto

  r = r1
fim enquanto

escreva "O menor número foi ", n, "."
FIM
*/