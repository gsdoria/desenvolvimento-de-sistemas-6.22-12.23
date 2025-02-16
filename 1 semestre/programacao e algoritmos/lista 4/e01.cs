using System;

class Program {
  public static void Main (string[] args) {
    double[] i = new double[7], p = new double[7];
    double q=0, im=0;

    for(int j=0; j<7; j++){
      Console.Write ("\nEscreva sua idade. ");
      i[j] = double.Parse(Console.ReadLine());

      Console.Write ("Escreva seu peso. ");
      p[j] = double.Parse(Console.ReadLine());
    }

    for(int j=0; j<7; j++){
      if(p[j]>90){ q++; }
      im += i[j];
    }

    Console.WriteLine("\nTem {0} pessoas com mais de 90kg.", q);
    Console.WriteLine("A média das idades é de {0:F2}.", im/7);
    
  }
}