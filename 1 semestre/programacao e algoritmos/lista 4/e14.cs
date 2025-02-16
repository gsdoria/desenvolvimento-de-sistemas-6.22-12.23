using System;

class Program {
  public static void Main (string[] args) {
    double [] n = new double[2];
    double v, p, d=0;

    for(int i=0; i<=1; i++){
      Console.Write ("Digite a nota. "); v = double.Parse(Console.ReadLine());

      Console.Write ("Digite o peso da nota. "); p = double.Parse(Console.ReadLine());

      d += p; n[i] = v * p;
    }
    Console.WriteLine("\nA média ponderada das notas é de {0:F1}.", (n[0]+n[1])/d);
  }
}