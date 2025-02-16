using System;

class Program {
  public static void Main (string[] args) {
    string cl;
    Console.WriteLine ("Escreva o código do livro.");
    cl = Console.ReadLine();

    if(cl=="a"){
      Console.WriteLine("O livro é ficcional.");
    }else if(cl=="b"){
      Console.WriteLine("O livro é não-ficcional.");
    }else{
      Console.WriteLine("Código inválido.");
    }
  }
}

/*INICIO
var cl: texto

escreva "Escreva o código do livro."
leia cl

se cl=="a"
  escreva "O livro é ficcional."
se não se cl=="b"
  escreva "O livro é não-ficcional."
se não
  escreva "Código inválido."
fim se

FIM*/