using System;

class Program {
  public static void Main (string[] args) {
    double altura, sexo, peso;

    Console.WriteLine("Escreva sua altura em metros.");
    altura = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite 0 para masculino ou 1 para feminino.");
    sexo = double.Parse(Console.ReadLine());

    if(sexo==0){
      peso = altura*72.7 - 58;
    }
    else{
      peso = altura*62.1 - 44.7;
    }
    Console.WriteLine("Seu peso ideal é de {0:F2} kg.", peso);
  }
}