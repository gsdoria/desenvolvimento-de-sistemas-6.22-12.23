using System;

class Program {
  public static void Main (string[] args) {
    double [] n = new double[10];
    int q=0;

    for(int i=0; i<10; i++){
      Console.Write ("Escreva um número. "); n[i] = double.Parse(Console.ReadLine());
      if (n[i]<90 && n[i]>30){ q++; }
    }

    Console.WriteLine ("{0} estão entre 30 e 90.", q);
  }
}