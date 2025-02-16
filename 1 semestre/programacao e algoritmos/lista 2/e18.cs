using System;

class Program {
  public static void Main (string[] args) {
    int an;
    Console.WriteLine ("Escreva o seu ano de nascimento.");
    an = int.Parse(Console.ReadLine());

    Console.WriteLine("Você tem {0} anos.", 2022-an);
    
    if (2022-an>=16){ 
      if(2022-an<18){
        Console.WriteLine("Você já pode votar.");
      }else{
        Console.Write("Você já pode votar e tirar sua carteira de motorista.");
      }
    }
  }
}

/*
INICIO
var an: inteiro
escreva "Escreva sua idade."
leia an

escreva "Você tem ",2022-an ," anos."

se 2022-an>16
  se 2022-an<18
    escreva "Você já pode votar."
  se não
    escreva "Você já pode votar e tirar sua carteira de motorista."
  fim se
fim se
FIM
*/