using System;

class Program {
  public static void Main (string[] args) {
    double n = 0;

    for(int i=0; i<3; i++){
      Console.Write ("Digite a {0}ª nota. ", i+1);
      n += double.Parse(Console.ReadLine());
    }

    n/=3;

    Console.WriteLine("\nA média das notas é de {0:F1} e o aluno foi {1}.", n, n>=7 ? "aprovado" : "reprovado");
  }
}